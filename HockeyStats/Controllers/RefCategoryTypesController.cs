using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HockeyStats.Data;
using HockeyStats.Models;

namespace HockeyStats.Controllers
{
    public class RefCategoryTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RefCategoryTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RefCategoryTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RefCategoryType.ToListAsync());
        }

        // GET: RefCategoryTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refCategoryType = await _context.RefCategoryType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refCategoryType == null)
            {
                return NotFound();
            }

            return View(refCategoryType);
        }

        // GET: RefCategoryTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RefCategoryTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RefCategoryTypeName")] RefCategoryType refCategoryType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refCategoryType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(refCategoryType);
        }

        // GET: RefCategoryTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refCategoryType = await _context.RefCategoryType.FindAsync(id);
            if (refCategoryType == null)
            {
                return NotFound();
            }
            return View(refCategoryType);
        }

        // POST: RefCategoryTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RefCategoryTypeName")] RefCategoryType refCategoryType)
        {
            if (id != refCategoryType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refCategoryType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefCategoryTypeExists(refCategoryType.Id))
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
            return View(refCategoryType);
        }

        // GET: RefCategoryTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refCategoryType = await _context.RefCategoryType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refCategoryType == null)
            {
                return NotFound();
            }

            return View(refCategoryType);
        }

        // POST: RefCategoryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var refCategoryType = await _context.RefCategoryType.FindAsync(id);
            _context.RefCategoryType.Remove(refCategoryType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefCategoryTypeExists(int id)
        {
            return _context.RefCategoryType.Any(e => e.Id == id);
        }
    }
}
