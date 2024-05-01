using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PriscilaZuniga_Examen1P.Models;

namespace PriscilaZuniga_Examen1P.Controllers
{
    public class PZClassController : Controller
    {
        private readonly PriscilaZuniga_DBContext _context;

        public PZClassController(PriscilaZuniga_DBContext context)
        {
            _context = context;
        }

        // GET: PZClass
        public async Task<IActionResult> Index()
        {
            return View(await _context.PZClass.ToListAsync());
        }

        // GET: PZClass/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pZClass = await _context.PZClass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pZClass == null)
            {
                return NotFound();
            }

            return View(pZClass);
        }

        // GET: PZClass/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PZClass/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Edad,PZ_Peso,PZ_Apodo,PZ_Activo,PZ_FechaNacimiento")] PZClass pZClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pZClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pZClass);
        }

        // GET: PZClass/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pZClass = await _context.PZClass.FindAsync(id);
            if (pZClass == null)
            {
                return NotFound();
            }
            return View(pZClass);
        }

        // POST: PZClass/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Edad,PZ_Peso,PZ_Apodo,PZ_Activo,PZ_FechaNacimiento")] PZClass pZClass)
        {
            if (id != pZClass.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pZClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PZClassExists(pZClass.ID))
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
            return View(pZClass);
        }

        // GET: PZClass/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pZClass = await _context.PZClass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pZClass == null)
            {
                return NotFound();
            }

            return View(pZClass);
        }

        // POST: PZClass/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pZClass = await _context.PZClass.FindAsync(id);
            if (pZClass != null)
            {
                _context.PZClass.Remove(pZClass);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PZClassExists(int id)
        {
            return _context.PZClass.Any(e => e.ID == id);
        }
    }
}
