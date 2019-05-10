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
    public class RefDistriktsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RefDistriktsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RefDistrikts
        public async Task<IActionResult> Index()
        {
            return View(await _context.RefDistrikt.ToListAsync());
        }

        // GET: RefDistrikts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refDistrikt = await _context.RefDistrikt
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refDistrikt == null)
            {
                return NotFound();
            }

            return View(refDistrikt);
        }

        // GET: RefDistrikts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RefDistrikts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RefDistriktName")] RefDistrikt refDistrikt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refDistrikt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(refDistrikt);
        }

        // GET: RefDistrikts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refDistrikt = await _context.RefDistrikt.FindAsync(id);
            if (refDistrikt == null)
            {
                return NotFound();
            }
            return View(refDistrikt);
        }

        // POST: RefDistrikts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RefDistriktName")] RefDistrikt refDistrikt)
        {
            if (id != refDistrikt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refDistrikt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefDistriktExists(refDistrikt.Id))
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
            return View(refDistrikt);
        }

        // GET: RefDistrikts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refDistrikt = await _context.RefDistrikt
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refDistrikt == null)
            {
                return NotFound();
            }

            return View(refDistrikt);
        }

        // POST: RefDistrikts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var refDistrikt = await _context.RefDistrikt.FindAsync(id);
            _context.RefDistrikt.Remove(refDistrikt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefDistriktExists(int id)
        {
            return _context.RefDistrikt.Any(e => e.Id == id);
        }
    }
}
