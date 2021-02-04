using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NBS2021.Data;
using NBS2021.Models.DataModels;

namespace NBS2021.Controllers.AdministrationControllers
{
    public class SallaryAccountsController : Controller
    {
        private readonly NBS2021Context _context;

        public SallaryAccountsController(NBS2021Context context)
        {
            _context = context;
        }

        // GET: SallaryAccounts
        public async Task<IActionResult> Index()
        {
            var nBS2021Context = _context.SallaryAccount.Include(s => s.AccountOwner);
            return View(await nBS2021Context.ToListAsync());
        }

        // GET: SallaryAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sallaryAccount = await _context.SallaryAccount
                .Include(s => s.AccountOwner)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sallaryAccount == null)
            {
                return NotFound();
            }

            return View(sallaryAccount);
        }

        // GET: SallaryAccounts/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id");
            return View();
        }

        // POST: SallaryAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PersonId,AccountName,AccountBalance")] SallaryAccount sallaryAccount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sallaryAccount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", sallaryAccount.PersonId);
            return View(sallaryAccount);
        }

        // GET: SallaryAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sallaryAccount = await _context.SallaryAccount.FindAsync(id);
            if (sallaryAccount == null)
            {
                return NotFound();
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", sallaryAccount.PersonId);
            return View(sallaryAccount);
        }

        // POST: SallaryAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PersonId,AccountName,AccountBalance")] SallaryAccount sallaryAccount)
        {
            if (id != sallaryAccount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sallaryAccount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SallaryAccountExists(sallaryAccount.Id))
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
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", sallaryAccount.PersonId);
            return View(sallaryAccount);
        }

        // GET: SallaryAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sallaryAccount = await _context.SallaryAccount
                .Include(s => s.AccountOwner)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sallaryAccount == null)
            {
                return NotFound();
            }

            return View(sallaryAccount);
        }

        // POST: SallaryAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sallaryAccount = await _context.SallaryAccount.FindAsync(id);
            _context.SallaryAccount.Remove(sallaryAccount);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SallaryAccountExists(int id)
        {
            return _context.SallaryAccount.Any(e => e.Id == id);
        }
    }
}
