using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;

namespace DoAnNhom11.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class VoucherCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoucherCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/VoucherCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.VoucherCategory.ToListAsync());
        }

        // GET: Admin/VoucherCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucherCategory = await _context.VoucherCategory
                .FirstOrDefaultAsync(m => m.VoucherCategoryId == id);
            if (voucherCategory == null)
            {
                return NotFound();
            }

            return View(voucherCategory);
        }

        // GET: Admin/VoucherCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/VoucherCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VoucherCategoryId,TenLoai")] VoucherCategory voucherCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voucherCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voucherCategory);
        }

        // GET: Admin/VoucherCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucherCategory = await _context.VoucherCategory.FindAsync(id);
            if (voucherCategory == null)
            {
                return NotFound();
            }
            return View(voucherCategory);
        }

        // POST: Admin/VoucherCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VoucherCategoryId,TenLoai")] VoucherCategory voucherCategory)
        {
            if (id != voucherCategory.VoucherCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voucherCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoucherCategoryExists(voucherCategory.VoucherCategoryId))
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
            return View(voucherCategory);
        }

        // GET: Admin/VoucherCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucherCategory = await _context.VoucherCategory
                .FirstOrDefaultAsync(m => m.VoucherCategoryId == id);
            if (voucherCategory == null)
            {
                return NotFound();
            }

            return View(voucherCategory);
        }

        // POST: Admin/VoucherCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voucherCategory = await _context.VoucherCategory.FindAsync(id);
            if (voucherCategory != null)
            {
                _context.VoucherCategory.Remove(voucherCategory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoucherCategoryExists(int id)
        {
            return _context.VoucherCategory.Any(e => e.VoucherCategoryId == id);
        }
    }
}
