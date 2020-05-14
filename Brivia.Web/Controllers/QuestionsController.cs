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

        // GET: Questions/Details/5
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

        // GET: Questions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Question,CorrectAnswer,IncorrectAnswers")] QuestionEntity questionEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(questionEntity);
        }

        // GET: Questions/Edit/5
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

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Question,CorrectAnswer,IncorrectAnswers")] QuestionEntity questionEntity)
        {
            if (id != questionEntity.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionEntityExists(questionEntity.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(questionEntity);
        }

        // GET: Questions/Delete/5
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

            return View(questionEntity);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionEntity = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(questionEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionEntityExists(int id)
        {
            return _context.Questions.Any(e => e.ID == id);
        }
    }
}
