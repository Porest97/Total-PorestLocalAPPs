using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IdentityUserLab.Data;
using IdentityUserLab.Models;
using Microsoft.AspNetCore.Authorization;

namespace IdentityUserLab.Controllers
{
    [Authorize(Roles = "Admin,SuperUser")]    
    public class PeopleController : Controller
    {
        private readonly LabContext _context;

        public PeopleController(LabContext context)
        {
            _context = context;
        }


        // GET: Assets with Site - search
        public async Task<IActionResult> IndexSearch(string searchString, string searchString1,
            string searchString2, string searchString3, string searchString4)
        {
            var people = from p in _context.Person                

                         select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                people = people
                .Where(s => s.FirstName.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                people = people
                .Where(s => s.LastName.Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                people = people
                .Where(s => s.PhoneNumber1.Contains(searchString2));
                

            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                people = people
                .Where(s => s.Email.Contains(searchString3));

            }
            if (!String.IsNullOrEmpty(searchString4))
            {
                people = people
                .Where(s => s.Email.Contains(searchString4));

            }


            return View(await people.ToListAsync());
        }


        // GET: People

        public async Task<IActionResult> Index()
        {
            return View(await _context.Person.ToListAsync());
        }
       
        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }
        [Authorize(Roles = "Admin")]
        // GET: People/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,StreetAddress,ZipCode,City,Country,Ssn,PhoneNumber1,PhoneNumber2,Email")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexSearch));
            }
            return View(person);
        }
        [Authorize(Roles = "Admin")]
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
            return View(person);
        }
        
        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,StreetAddress,ZipCode,City,Country,Ssn,PhoneNumber1,PhoneNumber2,Email")] Person person)
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
                return RedirectToAction(nameof(IndexSearch));
            }
            return View(person);
        }
        [Authorize(Roles = "Admin")]
        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
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
            return RedirectToAction(nameof(IndexSearch));
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
