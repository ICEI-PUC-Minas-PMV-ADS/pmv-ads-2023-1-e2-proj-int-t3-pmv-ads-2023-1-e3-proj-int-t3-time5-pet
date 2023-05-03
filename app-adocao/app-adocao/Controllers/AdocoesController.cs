using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_adocao.Models;

namespace app_adocao.Controllers
{
    public class AdocoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdocoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Adocoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Adocoes.Include(a => a.Pet).Include(a => a.Requerente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Adocoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Adocoes == null)
            {
                return NotFound();
            }

            var adocao = await _context.Adocoes
                .Include(a => a.Pet)
                .Include(a => a.Requerente)
                .FirstOrDefaultAsync(m => m.AdocaoId == id);
            if (adocao == null)
            {
                return NotFound();
            }

            return View(adocao);
        }

        // GET: Adocoes/Create
        public IActionResult Create()
        {
            ViewData["IdPet"] = new SelectList(_context.Pets, "ID", "Nome");
            ViewData["Adotante"] = new SelectList(_context.Requerentes, "Login", "Login");
            return View();
        }

        // POST: Adocoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdocaoId,Data,Status,Adotante,IdPet")] Adocao adocao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adocao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPet"] = new SelectList(_context.Pets, "ID", "Cor", adocao.IdPet);
            ViewData["Adotante"] = new SelectList(_context.Requerentes, "Login", "Login", adocao.Adotante);
            return View(adocao);
        }

        // GET: Adocoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Adocoes == null)
            {
                return NotFound();
            }

            var adocao = await _context.Adocoes.FindAsync(id);
            if (adocao == null)
            {
                return NotFound();
            }
            ViewData["IdPet"] = new SelectList(_context.Pets, "ID", "Cor", adocao.IdPet);
            ViewData["Adotante"] = new SelectList(_context.Requerentes, "Login", "Login", adocao.Adotante);
            return View(adocao);
        }

        // POST: Adocoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdocaoId,Data,Status,Adotante,IdPet")] Adocao adocao)
        {
            if (id != adocao.AdocaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adocao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdocaoExists(adocao.AdocaoId))
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
            ViewData["IdPet"] = new SelectList(_context.Pets, "ID", "Cor", adocao.IdPet);
            ViewData["Adotante"] = new SelectList(_context.Requerentes, "Login", "Login", adocao.Adotante);
            return View(adocao);
        }

        // GET: Adocoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Adocoes == null)
            {
                return NotFound();
            }

            var adocao = await _context.Adocoes
                .Include(a => a.Pet)
                .Include(a => a.Requerente)
                .FirstOrDefaultAsync(m => m.AdocaoId == id);
            if (adocao == null)
            {
                return NotFound();
            }

            return View(adocao);
        }

        // POST: Adocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Adocoes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Adocoes'  is null.");
            }
            var adocao = await _context.Adocoes.FindAsync(id);
            if (adocao != null)
            {
                _context.Adocoes.Remove(adocao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdocaoExists(int id)
        {
          return (_context.Adocoes?.Any(e => e.AdocaoId == id)).GetValueOrDefault();
        }
    }
}
