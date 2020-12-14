using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HarrisContactWeb.Data;

namespace HarrisContactWeb.Models
{
    public class BusinessContactsController : Controller
    {
        private readonly HarrisDbContext _context;

        public BusinessContactsController(HarrisDbContext context)
        {
            _context = context;
        }

        // GET: BusinessContacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.businessContacts.ToListAsync());
        }

        // GET: BusinessContacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessContact = await _context.businessContacts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (businessContact == null)
            {
                return NotFound();
            }

            return View(businessContact);
        }

        // GET: BusinessContacts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BusinessContacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,bName,bEmail,bNumber")] BusinessContact businessContact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(businessContact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(businessContact);
        }

        // GET: BusinessContacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessContact = await _context.businessContacts.FindAsync(id);
            if (businessContact == null)
            {
                return NotFound();
            }
            return View(businessContact);
        }

        // POST: BusinessContacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,bName,bEmail,bNumber")] BusinessContact businessContact)
        {
            if (id != businessContact.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(businessContact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessContactExists(businessContact.ID))
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
            return View(businessContact);
        }

        // GET: BusinessContacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessContact = await _context.businessContacts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (businessContact == null)
            {
                return NotFound();
            }

            return View(businessContact);
        }

        // POST: BusinessContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var businessContact = await _context.businessContacts.FindAsync(id);
            _context.businessContacts.Remove(businessContact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessContactExists(int id)
        {
            return _context.businessContacts.Any(e => e.ID == id);
        }
    }
}
