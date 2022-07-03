using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace RunningFeverApp.Controllers
{
    public class RunController : Controller
    {
        private readonly Context _context;

        public RunController(Context context)
        {
            _context = context;
        }

        // GET: Run
        public async Task<IActionResult> Index()
        {
              return _context.Runs != null ? 
                          View(await _context.Runs.ToListAsync()) :
                          Problem("Entity set 'Context.Runs'  is null.");
        }

        // GET: Run/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Runs == null)
            {
                return NotFound();
            }

            var run = await _context.Runs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (run == null)
            {
                return NotFound();
            }

            return View(run);
        }

        // GET: Run/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Run/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartTime,Miles,Route,Note")] Run run)
        {
            if (ModelState.IsValid)
            {
                _context.Add(run);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(run);
        }

        // GET: Run/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Runs == null)
            {
                return NotFound();
            }

            var run = await _context.Runs.FindAsync(id);
            if (run == null)
            {
                return NotFound();
            }
            return View(run);
        }

        // POST: Run/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartTime,Miles,Route,Note")] Run run)
        {
            if (id != run.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(run);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RunExists(run.Id))
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
            return View(run);
        }

        // GET: Run/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Runs == null)
            {
                return NotFound();
            }

            var run = await _context.Runs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (run == null)
            {
                return NotFound();
            }

            return View(run);
        }

        // POST: Run/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Runs == null)
            {
                return Problem("Entity set 'Context.Runs'  is null.");
            }
            var run = await _context.Runs.FindAsync(id);
            if (run != null)
            {
                _context.Runs.Remove(run);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RunExists(int id)
        {
          return (_context.Runs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
