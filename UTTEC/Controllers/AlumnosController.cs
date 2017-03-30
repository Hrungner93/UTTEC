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
    public class AlumnosController : Controller
    {
        private readonly UTTECContext _context;

        public AlumnosController(UTTECContext context)
        {
            _context = context;    
        }

        // GET: Alumnos
        public async Task<IActionResult> Index()
        {
            var UTTECContext = _context.Grado
                   .Include(s => s.GradoId)
                     .Include(s => s.Nombre);
            return View(await _context.Alumnos.ToListAsync());
        }

        // GET: Alumnos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumnos = await _context.Alumnos
                .SingleOrDefaultAsync(m => m.Matricula == id);
            if (alumnos == null)
            {
                return NotFound();
            }

            return View(alumnos);
        }

        // GET: Alumnos/Create
        public IActionResult Create() { 
           var UTTECContext = _context.Grado
                              .Include(s => s.GradoId)
                                .Include(s => s.Nombre);        
            return View(UTTECContext.ToList());
        }

        // POST: Alumnos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Matricula,Nombre,AppPaterno,AppMaterno")] Alumnos alumnos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alumnos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(alumnos);
        }

        // GET: Alumnos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumnos = await _context.Alumnos.SingleOrDefaultAsync(m => m.Matricula == id);
            if (alumnos == null)
            {
                return NotFound();
            }
            return View(alumnos);
        }

        // POST: Alumnos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Matricula,Nombre,AppPaterno,AppMaterno")] Alumnos alumnos)
        {
            if (id != alumnos.Matricula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alumnos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnosExists(alumnos.Matricula))
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
            return View(alumnos);
        }

        // GET: Alumnos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumnos = await _context.Alumnos
                .SingleOrDefaultAsync(m => m.Matricula == id);
            if (alumnos == null)
            {
                return NotFound();
            }

            return View(alumnos);
        }

        // POST: Alumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var alumnos = await _context.Alumnos.SingleOrDefaultAsync(m => m.Matricula == id);
            _context.Alumnos.Remove(alumnos);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AlumnosExists(string id)
        {
            return _context.Alumnos.Any(e => e.Matricula == id);
        }
    }
}
