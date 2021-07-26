using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DienThoai.Data;
using DienThoai.Models;

namespace DienThoai.Controllers
{
    public class HangController : Controller
    {
        private readonly AppDbContext _context;

        public HangController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Hang
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hang.ToListAsync());
        }

        // GET: Hang/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hang = await _context.Hang
                .FirstOrDefaultAsync(m => m.HangID == id);
            if (hang == null)
            {
                return NotFound();
            }

            return View(hang);
        }

        // GET: Hang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HangID,TenHang")] Hang hang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hang);
        }

        // GET: Hang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hang = await _context.Hang.FindAsync(id);
            if (hang == null)
            {
                return NotFound();
            }
            return View(hang);
        }

        // POST: Hang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HangID,TenHang")] Hang hang)
        {
            if (id != hang.HangID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangExists(hang.HangID))
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
            return View(hang);
        }

        // GET: Hang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hang = await _context.Hang
                .FirstOrDefaultAsync(m => m.HangID == id);
            if (hang == null)
            {
                return NotFound();
            }

            return View(hang);
        }

        // POST: Hang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hang = await _context.Hang.FindAsync(id);
            _context.Hang.Remove(hang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangExists(string id)
        {
            return _context.Hang.Any(e => e.HangID == id);
        }
    }
}
