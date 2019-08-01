﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaTicketer.Data;
using CinemaTicketer.Shared.Models;

namespace CinemaTicketer.Controllers
{
    public class ScreeningsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScreeningsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Screenings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Screenings.ToListAsync());
        }

        // GET: Screenings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screening = await _context.Screenings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (screening == null)
            {
                return NotFound();
            }

            return View(screening);
        }

        // GET: Screenings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Screenings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date")] Screening screening)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screening);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screening);
        }

        // GET: Screenings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screening = await _context.Screenings.FindAsync(id);
            if (screening == null)
            {
                return NotFound();
            }
            return View(screening);
        }

        // POST: Screenings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date")] Screening screening)
        {
            if (id != screening.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(screening);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScreeningExists(screening.Id))
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
            return View(screening);
        }

        // GET: Screenings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screening = await _context.Screenings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (screening == null)
            {
                return NotFound();
            }

            return View(screening);
        }

        // POST: Screenings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var screening = await _context.Screenings.FindAsync(id);
            _context.Screenings.Remove(screening);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScreeningExists(int id)
        {
            return _context.Screenings.Any(e => e.Id == id);
        }
    }
}
