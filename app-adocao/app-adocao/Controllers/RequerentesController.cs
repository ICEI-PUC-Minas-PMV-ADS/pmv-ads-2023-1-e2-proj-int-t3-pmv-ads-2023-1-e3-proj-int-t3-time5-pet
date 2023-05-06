using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_adocao.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace app_adocao.Controllers
{
    //[Authorize]
    public class RequerentesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequerentesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Requerentes
        public async Task<IActionResult> Index()
        {
              return _context.Requerentes != null ? 
                          View(await _context.Requerentes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Requerentes'  is null.");
        }

        // GET: Requerentes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Requerentes == null)
            {
                return NotFound();
            }

            var requerente = await _context.Requerentes
                .FirstOrDefaultAsync(m => m.Login == id);
            if (requerente == null)
            {
                return NotFound();
            }

            return View(requerente);
        }

        // GET: Requerentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Requerentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tipo,Raca,Login,Nome,Senha,Cidade,Estado")] Requerente requerente)
        {
            if (ModelState.IsValid)
            {
                requerente.Senha = BCrypt.Net.BCrypt.HashPassword(requerente.Senha);
                _context.Add(requerente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requerente);
        }

        // GET: Requerentes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Requerentes == null)
            {
                return NotFound();
            }

            var requerente = await _context.Requerentes.FindAsync(id);
            if (requerente == null)
            {
                return NotFound();
            }
            return View(requerente);
        }

        // POST: Requerentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Tipo,Raca,Login,Nome,Senha,Cidade,Estado")] Requerente requerente)
        {
            if (id != requerente.Login)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    requerente.Senha = BCrypt.Net.BCrypt.HashPassword(requerente.Senha);
                    _context.Update(requerente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequerenteExists(requerente.Login))
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
            return View(requerente);
        }

        // GET: Requerentes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Requerentes == null)
            {
                return NotFound();
            }

            var requerente = await _context.Requerentes
                .FirstOrDefaultAsync(m => m.Login == id);
            if (requerente == null)
            {
                return NotFound();
            }

            return View(requerente);
        }

        // POST: Requerentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Requerentes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Requerentes'  is null.");
            }
            var requerente = await _context.Requerentes.FindAsync(id);
            if (requerente != null)
            {
                _context.Requerentes.Remove(requerente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequerenteExists(string id)
        {
          return (_context.Requerentes?.Any(e => e.Login == id)).GetValueOrDefault();
        }
    }
}
