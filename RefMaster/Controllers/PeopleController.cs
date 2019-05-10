using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RefMaster.Data;
using RefMaster.Models;

namespace RefMaster.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Person.Include(p => p.Club).Include(p => p.RefCategory).Include(p => p.RefCategoryType).Include(p => p.RefDistrikt).Include(p => p.RefType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.Club)
                .Include(p => p.RefCategory)
                .Include(p => p.RefCategoryType)
                .Include(p => p.RefDistrikt)
                .Include(p => p.RefType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: People/Create
        public IActionResult Create()
        {
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "Id");
            ViewData["RefCategoryId"] = new SelectList(_context.Set<RefCategory>(), "Id", "Id");
            ViewData["RefCategoryTypeId"] = new SelectList(_context.Set<RefCategoryType>(), "Id", "Id");
            ViewData["RefDistriktId"] = new SelectList(_context.Set<RefDistrikt>(), "Id", "Id");
            ViewData["RefTypeId"] = new SelectList(_context.Set<RefType>(), "Id", "Id");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,RefNumber,BirthDate,RefTypeId,RefCategoryId,RefCategoryTypeId,RefDistriktId,ClubId,StreetAddress,Zipcode,County,Country")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "Id", person.ClubId);
            ViewData["RefCategoryId"] = new SelectList(_context.Set<RefCategory>(), "Id", "Id", person.RefCategoryId);
            ViewData["RefCategoryTypeId"] = new SelectList(_context.Set<RefCategoryType>(), "Id", "Id", person.RefCategoryTypeId);
            ViewData["RefDistriktId"] = new SelectList(_context.Set<RefDistrikt>(), "Id", "Id", person.RefDistriktId);
            ViewData["RefTypeId"] = new SelectList(_context.Set<RefType>(), "Id", "Id", person.RefTypeId);
            return View(person);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "Id", person.ClubId);
            ViewData["RefCategoryId"] = new SelectList(_context.Set<RefCategory>(), "Id", "Id", person.RefCategoryId);
            ViewData["RefCategoryTypeId"] = new SelectList(_context.Set<RefCategoryType>(), "Id", "Id", person.RefCategoryTypeId);
            ViewData["RefDistriktId"] = new SelectList(_context.Set<RefDistrikt>(), "Id", "Id", person.RefDistriktId);
            ViewData["RefTypeId"] = new SelectList(_context.Set<RefType>(), "Id", "Id", person.RefTypeId);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,FirstName,LastName,RefNumber,BirthDate,RefTypeId,RefCategoryId,RefCategoryTypeId,RefDistriktId,ClubId,StreetAddress,Zipcode,County,Country")] Person person)
        {
            if (id != person.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.Id))
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
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "Id", person.ClubId);
            ViewData["RefCategoryId"] = new SelectList(_context.Set<RefCategory>(), "Id", "Id", person.RefCategoryId);
            ViewData["RefCategoryTypeId"] = new SelectList(_context.Set<RefCategoryType>(), "Id", "Id", person.RefCategoryTypeId);
            ViewData["RefDistriktId"] = new SelectList(_context.Set<RefDistrikt>(), "Id", "Id", person.RefDistriktId);
            ViewData["RefTypeId"] = new SelectList(_context.Set<RefType>(), "Id", "Id", person.RefTypeId);
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.Club)
                .Include(p => p.RefCategory)
                .Include(p => p.RefCategoryType)
                .Include(p => p.RefDistrikt)
                .Include(p => p.RefType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Person.FindAsync(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(string id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
