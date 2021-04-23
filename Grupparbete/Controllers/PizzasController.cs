﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Grupparbete.Data;
using Grupparbete.Models;

namespace Grupparbete.Controllers
{
    public class PizzasController : Controller
    {
        private readonly MvcPizzaContext _context;

        public PizzasController(MvcPizzaContext context)
        {
            _context = context;
        }

        // GET: Pizzas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pizzas.ToListAsync());
        }

        // GET: Pizzas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzas = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pizzas == null)
            {
                return NotFound();
            }

            return View(pizzas);
        }

        // GET: Pizzas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pizzas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PizzaName,PizzaSizes,Price")] Pizzas pizzas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizzas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pizzas);
        }

        // GET: Pizzas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzas = await _context.Pizzas.FindAsync(id);
            if (pizzas == null)
            {
                return NotFound();
            }
            return View(pizzas);
        }

        // POST: Pizzas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PizzaName,PizzaSizes,Price")] Pizzas pizzas)
        {
            if (id != pizzas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizzas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzasExists(pizzas.Id))
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
            return View(pizzas);
        }

        // GET: Pizzas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzas = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pizzas == null)
            {
                return NotFound();
            }

            return View(pizzas);
        }

        // POST: Pizzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizzas = await _context.Pizzas.FindAsync(id);
            _context.Pizzas.Remove(pizzas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzasExists(int id)
        {
            return _context.Pizzas.Any(e => e.Id == id);
        }
    }
}
