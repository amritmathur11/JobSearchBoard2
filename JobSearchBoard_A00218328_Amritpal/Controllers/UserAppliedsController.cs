using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobSearchBoard_A00218328_Amritpal.Contexts;
using JobSearchBoard_A00218328_Amritpal.Models;

namespace JobSearchBoard_A00218328_Amritpal.Controllers
{
    public class UserAppliedsController : Controller
    {
        private readonly Context _context;

        public UserAppliedsController(Context context)
        {
            _context = context;
        }

        // GET: UserApplieds
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserApplied.ToListAsync());
        }

        // GET: UserApplieds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userApplied = await _context.UserApplied
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userApplied == null)
            {
                return NotFound();
            }

            return View(userApplied);
        }

        // GET: UserApplieds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserApplieds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description")] UserApplied userApplied)
        {
            if (ModelState.IsValid)
            {
                userApplied.UserName = User.Identity.Name;
                _context.Add(userApplied);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userApplied);
        }

        // GET: UserApplieds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userApplied = await _context.UserApplied.FindAsync(id);
            if (userApplied == null)
            {
                return NotFound();
            }
            return View(userApplied);
        }

        // POST: UserApplieds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description")] UserApplied userApplied)
        {
            if (id != userApplied.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    userApplied.UserName = User.Identity.Name;
                    _context.Update(userApplied);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserAppliedExists(userApplied.ID))
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
            return View(userApplied);
        }

        // GET: UserApplieds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userApplied = await _context.UserApplied
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userApplied == null)
            {
                return NotFound();
            }

            return View(userApplied);
        }

        // POST: UserApplieds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userApplied = await _context.UserApplied.FindAsync(id);
            _context.UserApplied.Remove(userApplied);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserAppliedExists(int id)
        {
            return _context.UserApplied.Any(e => e.ID == id);
        }
    }
}
