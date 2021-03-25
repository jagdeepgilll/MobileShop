using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MobileShop.Data;
using MobileShop.Models;

namespace MobileShop.Controllers
{
    [Authorize]
    public class ConfigrationsController : Controller
    {
        private readonly PhoneDbContext _context;

        public ConfigrationsController(PhoneDbContext context)
        {
            _context = context;
        }

        // GET: Configrations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Configration.ToListAsync());
        }

        // GET: Configrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configration = await _context.Configration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configration == null)
            {
                return NotFound();
            }

            return View(configration);
        }

        // GET: Configrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Configrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Model,PhoneId,Storage,RAM")] Configration configration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(configration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(configration);
        }

        // GET: Configrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configration = await _context.Configration.FindAsync(id);
            if (configration == null)
            {
                return NotFound();
            }
            return View(configration);
        }

        // POST: Configrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Model,PhoneId,Storage,RAM")] Configration configration)
        {
            if (id != configration.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(configration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfigrationExists(configration.Id))
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
            return View(configration);
        }

        // GET: Configrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configration = await _context.Configration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configration == null)
            {
                return NotFound();
            }

            return View(configration);
        }

        // POST: Configrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var configration = await _context.Configration.FindAsync(id);
            _context.Configration.Remove(configration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConfigrationExists(int id)
        {
            return _context.Configration.Any(e => e.Id == id);
        }
    }
}
