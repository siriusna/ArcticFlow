using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArcticFlow.Data;
using ArcticFlow.Models.Entities;

namespace ArcticFlow.Controllers
{
    public class ArcticsController : Controller
    {
        private readonly ArcticDataContext _context;

        public ArcticsController(ArcticDataContext context)
        {
            _context = context;
        }

        // GET: Arctics
        public async Task<IActionResult> Index()
        {
            var nemaDbContext = _context.Arctics.Include(e => e.Categorias);
            return View(nemaDbContext);
        }

        // GET: Arctics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arctic = await _context.Arctics
                .FirstOrDefaultAsync(m => m.ArcticID == id);
            if (arctic == null)
            {
                return NotFound();
            }

            return View(arctic);
        }

        // GET: Arctics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Arctics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArcticID,Nome,Email,Telefone,Endereco,Empresa,FotoPerfil,DataCriacao,DataNascimento,Descricao")] Arctic arctic)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arctic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arctic);
        }

        // GET: Arctics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arctic = await _context.Arctics.FindAsync(id);
            if (arctic == null)
            {
                return NotFound();
            }
            return View(arctic);
        }

        // POST: Arctics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArcticID,Nome,Email,Telefone,Endereco,Empresa,FotoPerfil,DataCriacao,DataNascimento,Descricao")] Arctic arctic)
        {
            if (id != arctic.ArcticID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arctic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArcticExists(arctic.ArcticID))
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
            return View(arctic);
        }

        // GET: Arctics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arctic = await _context.Arctics
                .FirstOrDefaultAsync(m => m.ArcticID == id);
            if (arctic == null)
            {
                return NotFound();
            }

            return View(arctic);
        }

        // POST: Arctics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var arctic = await _context.Arctics.FindAsync(id);
            _context.Arctics.Remove(arctic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArcticExists(int id)
        {
            return _context.Arctics.Any(e => e.ArcticID == id);
        }
    }
}
