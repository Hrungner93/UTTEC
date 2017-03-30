using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UTTEC.Data;
using UTTEC.Models;

namespace UTTEC.Controllers
{
    public class GradoesController : Controller
    {
        private readonly UTTECContext _context;

        public GradoesController(UTTECContext context)
        {
            _context = context;    
        }

        // GET: Gradoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grado.ToListAsync());
        }

        // GET: Gradoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grado = await _context.Grado
                .SingleOrDefaultAsync(m => m.GradoId == id);
            if (grado == null)
            {
                return NotFound();
            }

            return View(grado);
        }

        // GET: Gradoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gradoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GradoId,Nombre,Descripcion")] Grado grado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grado);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(grado);
        }

        // GET: Gradoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grado = await _context.Grado.SingleOrDefaultAsync(m => m.GradoId == id);
            if (grado == null)
            {
                return NotFound();
            }
            return View(grado);
        }

        // POST: Gradoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GradoId,Nombre,Descripcion")] Grado grado)
        {
            if (id != grado.GradoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradoExists(grado.GradoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(grado);
        }

        // GET: Gradoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grado = await _context.Grado
                .SingleOrDefaultAsync(m => m.GradoId == id);
            if (grado == null)
            {
                return NotFound();
            }

            return View(grado);
        }

        // POST: Gradoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grado = await _context.Grado.SingleOrDefaultAsync(m => m.GradoId == id);
            _context.Grado.Remove(grado);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool GradoExists(int id)
        {
            return _context.Grado.Any(e => e.GradoId == id);
        }
    }
}
