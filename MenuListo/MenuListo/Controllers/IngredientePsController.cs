using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MenuListo.Data;
using MenuListo.Models;

namespace MenuListo.Controllers
{
    public class IngredientePsController : Controller
    {
        private readonly Context _context;

        public IngredientePsController(Context context)
        {
            _context = context;
        }

        // GET: IngredientePs
        public async Task<IActionResult> Index()
        {
            return View(await _context.IngredienteP.ToListAsync());
        }

        // GET: IngredientePs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredienteP = await _context.IngredienteP
                .FirstOrDefaultAsync(m => m.id == id);
            if (ingredienteP == null)
            {
                return NotFound();
            }

            return View(ingredienteP);
        }

        // GET: IngredientePs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IngredientePs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre")] IngredienteP ingredienteP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ingredienteP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ingredienteP);
        }

        // GET: IngredientePs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredienteP = await _context.IngredienteP.FindAsync(id);
            if (ingredienteP == null)
            {
                return NotFound();
            }
            return View(ingredienteP);
        }

        // POST: IngredientePs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre")] IngredienteP ingredienteP)
        {
            if (id != ingredienteP.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingredienteP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngredientePExists(ingredienteP.id))
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
            return View(ingredienteP);
        }

        // GET: IngredientePs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredienteP = await _context.IngredienteP
                .FirstOrDefaultAsync(m => m.id == id);
            if (ingredienteP == null)
            {
                return NotFound();
            }

            return View(ingredienteP);
        }

        // POST: IngredientePs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ingredienteP = await _context.IngredienteP.FindAsync(id);
            _context.IngredienteP.Remove(ingredienteP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IngredientePExists(int id)
        {
            return _context.IngredienteP.Any(e => e.id == id);
        }
    }
}
