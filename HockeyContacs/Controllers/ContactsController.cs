using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HockeyContacs.Models;

namespace HockeyContacs.Controllers
{
    public class ContactsController : Controller
    {
        private readonly HockeyContacsContext _context;

        public ContactsController(HockeyContacsContext context)
        {
            _context = context;
        }

        // GET: Contacts
        public async Task<IActionResult> Index()
        {
            var hockeyContacsContext = _context.Contact.Include(c => c.Club).Include(c => c.Role).Include(c => c.Sport).Include(c => c.Team);
            return View(await hockeyContacsContext.ToListAsync());
        }

        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Club)
                .Include(c => c.Role)
                .Include(c => c.Sport)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "Id");
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "Id");
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "Id");
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "Id");
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClubId,TeamId,RoleId,SportId,DisrtictId,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "Id", contact.ClubId);
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "Id", contact.RoleId);
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "Id", contact.SportId);
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "Id", contact.TeamId);
            return View(contact);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "Id", contact.ClubId);
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "Id", contact.RoleId);
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "Id", contact.SportId);
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "Id", contact.TeamId);
            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClubId,TeamId,RoleId,SportId,DisrtictId,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
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
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "Id", contact.ClubId);
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "Id", contact.RoleId);
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "Id", contact.SportId);
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "Id", contact.TeamId);
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Club)
                .Include(c => c.Role)
                .Include(c => c.Sport)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
