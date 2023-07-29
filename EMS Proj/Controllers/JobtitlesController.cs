using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMS_Proj.Data;
using EMS_Proj.Models;

namespace EMS_Proj.Controllers
{
    public class JobtitlesController : Controller
    {
        private readonly AppDBcontext _context;

        public JobtitlesController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: Jobtitles
        public async Task<IActionResult> Index()
        {
              return _context.Jobtitles != null ? 
                          View(await _context.Jobtitles.ToListAsync()) :
                          Problem("Entity set 'AppDBcontext.Jobtitles'  is null.");
        }

        // GET: Jobtitles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Jobtitles == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.Jobtitles
                .FirstOrDefaultAsync(m => m.JobID == id);
            if (jobtitle == null)
            {
                return NotFound();
            }

            return View(jobtitle);
        }

        // GET: Jobtitles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jobtitles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobID,JobTitle,JobDescription")] Jobtitle jobtitle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobtitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobtitle);
        }

        // GET: Jobtitles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Jobtitles == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.Jobtitles.FindAsync(id);
            if (jobtitle == null)
            {
                return NotFound();
            }
            return View(jobtitle);
        }

        // POST: Jobtitles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobID,JobTitle,JobDescription")] Jobtitle jobtitle)
        {
            if (id != jobtitle.JobID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobtitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobtitleExists(jobtitle.JobID))
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
            return View(jobtitle);
        }

        // GET: Jobtitles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Jobtitles == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.Jobtitles
                .FirstOrDefaultAsync(m => m.JobID == id);
            if (jobtitle == null)
            {
                return NotFound();
            }

            return View(jobtitle);
        }

        // POST: Jobtitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Jobtitles == null)
            {
                return Problem("Entity set 'AppDBcontext.Jobtitles'  is null.");
            }
            var jobtitle = await _context.Jobtitles.FindAsync(id);
            if (jobtitle != null)
            {
                _context.Jobtitles.Remove(jobtitle);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobtitleExists(int id)
        {
          return (_context.Jobtitles?.Any(e => e.JobID == id)).GetValueOrDefault();
        }
    }
}
