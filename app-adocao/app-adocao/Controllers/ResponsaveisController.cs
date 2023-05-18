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
    public class ResponsaveisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResponsaveisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Responsaveis
        public async Task<IActionResult> Index()
        {
              return _context.Responsaveis != null ? 
                          View(await _context.Responsaveis.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Responsaveis'  is null.");
        }

        // GET: Responsaveis/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Responsaveis == null)
            {
                return NotFound();
            }

            var responsavel = await _context.Responsaveis
                .FirstOrDefaultAsync(m => m.Login == id);
            if (responsavel == null)
            {
                return NotFound();
            }

            return View(responsavel);
        }

        // GET: Responsaveis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Responsaveis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Contato,Login,Nome,Senha,Cidade,Estado,Email")] Responsavel responsavel)
        {
            if (ModelState.IsValid)
            {
                responsavel.Senha = BCrypt.Net.BCrypt.HashPassword(responsavel.Senha);
                _context.Add(responsavel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(responsavel);
        }

        // GET: Responsaveis/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Responsaveis == null)
            {
                return NotFound();
            }

            var responsavel = await _context.Responsaveis.FindAsync(id);
            if (responsavel == null)
            {
                return NotFound();
            }
            return View(responsavel);
        }

        // POST: Responsaveis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Contato,Login,Nome,Senha,Cidade,Estado,Email")] Responsavel responsavel)
        {
            if (id != responsavel.Login)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    responsavel.Senha = BCrypt.Net.BCrypt.HashPassword(responsavel.Senha);
                    _context.Update(responsavel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResponsavelExists(responsavel.Login))
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
            return View(responsavel);
        }

        // GET: Responsaveis/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Responsaveis == null)
            {
                return NotFound();
            }

            var responsavel = await _context.Responsaveis
                .FirstOrDefaultAsync(m => m.Login == id);
            if (responsavel == null)
            {
                return NotFound();
            }

            return View(responsavel);
        }

        // POST: Responsaveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Responsaveis == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Responsaveis'  is null.");
            }
            var responsavel = await _context.Responsaveis.FindAsync(id);
            if (responsavel != null)
            {
                _context.Responsaveis.Remove(responsavel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResponsavelExists(string id)
        {
          return (_context.Responsaveis?.Any(e => e.Login == id)).GetValueOrDefault();
        }
    }
}
