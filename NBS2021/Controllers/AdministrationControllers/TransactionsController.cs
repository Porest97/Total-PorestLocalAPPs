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
    public class TransactionsController : Controller
    {
        private readonly NBS2021Context _context;

        public TransactionsController(NBS2021Context context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            var nBS2021Context = _context.Transaction
                .Include(t => t.SallaryAccount)
                .Include(t => t.TransactionStatus);
            return View(await nBS2021Context.ToListAsync());
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.SallaryAccount)
                .Include(t => t.TransactionStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewData["SallaryAccountId"] = new SelectList(_context.SallaryAccount, "Id", "Id");
            ViewData["TransactionStatusId"] = new SelectList(_context.Set<TransactionStatus>(), "Id", "AccountName").OrderBy(t=>t.Text);
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTimePosted,DateTimeChanged,TransactionDate,SallaryAccountId,Description,NumberOf,Hours,Price,TransactionAmount,TransactionStatusId")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SallaryAccountId"] = new SelectList(_context.SallaryAccount, "Id", "Id", transaction.SallaryAccountId);
            ViewData["TransactionStatusId"] = new SelectList(_context.Set<TransactionStatus>(), "Id", "Id", transaction.TransactionStatusId);
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            ViewData["SallaryAccountId"] = new SelectList(_context.SallaryAccount, "Id", "Id", transaction.SallaryAccountId);
            ViewData["TransactionStatusId"] = new SelectList(_context.Set<TransactionStatus>(), "Id", "Id", transaction.TransactionStatusId);
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTimePosted,DateTimeChanged,TransactionDate,SallaryAccountId,Description,NumberOf,Hours,Price,TransactionAmount,TransactionStatusId")] Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.Id))
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
            ViewData["SallaryAccountId"] = new SelectList(_context.SallaryAccount, "Id", "Id", transaction.SallaryAccountId);
            ViewData["TransactionStatusId"] = new SelectList(_context.Set<TransactionStatus>(), "Id", "Id", transaction.TransactionStatusId);
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.SallaryAccount)
                .Include(t => t.TransactionStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaction = await _context.Transaction.FindAsync(id);
            _context.Transaction.Remove(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return _context.Transaction.Any(e => e.Id == id);
        }
    }
}
