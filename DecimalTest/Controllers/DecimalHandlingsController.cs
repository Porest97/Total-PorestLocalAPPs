using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DecimalTest.Data;
using DecimalTest.Models;

namespace DecimalTest.Controllers
{
    public class DecimalHandlingsController : Controller
    {
        private readonly DecimalTestContext _context;

        public DecimalHandlingsController(DecimalTestContext context)
        {
            _context = context;
        }

        // GET: DecimalHandlings
        public async Task<IActionResult> Index()
        {
            return View(await _context.DecimalHandling.ToListAsync());
        }

        // GET: DecimalHandlings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decimalHandling = await _context.DecimalHandling
                .FirstOrDefaultAsync(m => m.Id == id);
            if (decimalHandling == null)
            {
                return NotFound();
            }

            return View(decimalHandling);
        }

        // GET: DecimalHandlings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DecimalHandlings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Value1,Value2,Result")] DecimalHandling decimalHandling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(decimalHandling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(decimalHandling);
        }

        // GET: DecimalHandlings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decimalHandling = await _context.DecimalHandling.FindAsync(id);
            if (decimalHandling == null)
            {
                return NotFound();
            }
            return View(decimalHandling);
        }

        // POST: DecimalHandlings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Value1,Value2,Result")] DecimalHandling decimalHandling)
        {
            if (id != decimalHandling.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(decimalHandling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DecimalHandlingExists(decimalHandling.Id))
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
            return View(decimalHandling);
        }

        // GET: DecimalHandlings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decimalHandling = await _context.DecimalHandling
                .FirstOrDefaultAsync(m => m.Id == id);
            if (decimalHandling == null)
            {
                return NotFound();
            }

            return View(decimalHandling);
        }

        // POST: DecimalHandlings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var decimalHandling = await _context.DecimalHandling.FindAsync(id);
            _context.DecimalHandling.Remove(decimalHandling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DecimalHandlingExists(int id)
        {
            return _context.DecimalHandling.Any(e => e.Id == id);
        }
    }
}
