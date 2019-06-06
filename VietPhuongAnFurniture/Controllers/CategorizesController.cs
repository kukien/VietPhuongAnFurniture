using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VietPhuongAnFurniture.Data;
using VietPhuongAnFurniture.Models;

namespace VietPhuongAnFurniture.Controllers
{
    public class CategorizesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategorizesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Categorizes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categorizes.ToListAsync());
        }

        // GET: Categorizes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorize = await _context.Categorizes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorize == null)
            {
                return NotFound();
            }

            return View(categorize);
        }

        // GET: Categorizes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,CRUDDate,Id")] Categorize categorize)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categorize);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categorize);
        }

        // GET: Categorizes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorize = await _context.Categorizes.FindAsync(id);
            if (categorize == null)
            {
                return NotFound();
            }
            return View(categorize);
        }

        // POST: Categorizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Name,Description,CRUDDate,Id")] Categorize categorize)
        {
            if (id != categorize.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categorize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategorizeExists(categorize.Id))
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
            return View(categorize);
        }

        // GET: Categorizes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorize = await _context.Categorizes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorize == null)
            {
                return NotFound();
            }

            return View(categorize);
        }

        // POST: Categorizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var categorize = await _context.Categorizes.FindAsync(id);
            _context.Categorizes.Remove(categorize);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategorizeExists(string id)
        {
            return _context.Categorizes.Any(e => e.Id == id);
        }
    }
}
