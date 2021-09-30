using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class PlatoesController : Controller
    {
        private readonly PryectoFinalContext _context;

        public string SearchPhrase { get; private set; }

        public PlatoesController(PryectoFinalContext context)
        {
            _context = context;
        }

        // GET: Platoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plato.ToListAsync());
        }
        // GET: Platoes/ShowSearch
        public async Task<IActionResult> ShowSearch()
        {
            return View("ShowSearch");
        }

        // GET: Platoes/ShowSearchResultados
        public async Task<IActionResult> ShowSearchResultados(string SearchPhrase)
        {
            return View("Index",await _context.Plato.Where(p=>p.descripcion.Contains(SearchPhrase)).ToListAsync());
        }





        // GET: Platoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato
                .FirstOrDefaultAsync(m => m.id == id);
            if (plato == null)
            {
                return NotFound();
            }

            return View(plato);
        }


        // GET: Platoes/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }



        

        // POST: Platoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,descripcion,pasoapaso,idp,ids")] Plato plato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plato);
        }

        // GET: Platoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato.FindAsync(id);
            if (plato == null)
            {
                return NotFound();
            }
            return View(plato);
        }

        // POST: Platoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,descripcion,pasoapaso,idp,ids")] Plato plato)
        {
            if (id != plato.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlatoExists(plato.id))
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
            return View(plato);
        }

        // GET: Platoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato
                .FirstOrDefaultAsync(m => m.id == id);
            if (plato == null)
            {
                return NotFound();
            }

            return View(plato);
        }

        // POST: Platoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plato = await _context.Plato.FindAsync(id);
            _context.Plato.Remove(plato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlatoExists(int id)
        {
            return _context.Plato.Any(e => e.id == id);
        }
    }
}
