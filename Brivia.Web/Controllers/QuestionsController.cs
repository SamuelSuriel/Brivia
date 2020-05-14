using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Brivia.Web.Data;
using Brivia.Web.Data.Entities;

namespace Brivia.Web.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly DataContext _context;

        public QuestionsController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Questions.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionEntity = await _context.Questions
                .FirstOrDefaultAsync(m => m.ID == id);
            if (questionEntity == null)
            {
                return NotFound();
            }

            return View(questionEntity);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QuestionEntity questionEntity)
        {
            if (ModelState.IsValid)
            {
                questionEntity.Question = questionEntity.Question.ToUpper();
                questionEntity.Answer1 = questionEntity.Answer1.ToUpper();
                questionEntity.Answer2 = questionEntity.Answer2.ToUpper();
                questionEntity.Answer3 = questionEntity.Answer3.ToUpper();
                questionEntity.Answer4 = questionEntity.Answer4.ToUpper();
                _context.Add(questionEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(questionEntity);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionEntity = await _context.Questions.FindAsync(id);
            if (questionEntity == null)
            {
                return NotFound();
            }
            return View(questionEntity);
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, QuestionEntity questionEntity)
        {
            if (id != questionEntity.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                questionEntity.Question = questionEntity.Question.ToUpper();
                questionEntity.Answer1 = questionEntity.Answer1.ToUpper();
                questionEntity.Answer2 = questionEntity.Answer2.ToUpper();
                questionEntity.Answer3 = questionEntity.Answer3.ToUpper();
                questionEntity.Answer4 = questionEntity.Answer4.ToUpper();
                _context.Update(questionEntity);
                await _context.SaveChangesAsync(); 
                return RedirectToAction(nameof(Index));
            }

            return View(questionEntity);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionEntity = await _context.Questions
                .FirstOrDefaultAsync(m => m.ID == id);
            if (questionEntity == null)
            {
                return NotFound();
            }

            _context.Questions.Remove(questionEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }       
    }
}
