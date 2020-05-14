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

        // GET: Questions
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
                questionEntity.CorrectAnswer = questionEntity.CorrectAnswer.ToUpper();
                questionEntity.IncorrectAnswers = questionEntity.IncorrectAnswers.ToUpper();
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
                questionEntity.CorrectAnswer = questionEntity.CorrectAnswer.ToUpper();
                questionEntity.IncorrectAnswers = questionEntity.IncorrectAnswers.ToUpper();
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
