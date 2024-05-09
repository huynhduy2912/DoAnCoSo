using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;

namespace DoAnNhom11.Controllers
{
    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Shops
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Shops.Include(s => s.ShopCategories);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Shops/Details/5
        public async Task<IActionResult> Details(int? ma)
        {
            if (ma == null)
            {
                return NotFound();
            }
            var shop = await _context.Shops
                .Include(s => s.ShopCategories)
                .FirstOrDefaultAsync(m => m.ShopId == ma);
            if (shop == null)
            {
                return NotFound();
            }
            var listProductByShop = await _context.Products
               .Where(p => p.ShopId == ma).AsNoTracking().ToListAsync();
            ViewBag.ProductList = listProductByShop;
            return View(shop);
        }

        // GET: Shops/Create
        public IActionResult Create()
        {
            ViewData["ShopCategoryId"] = new SelectList(_context.ShopCategories, "ShopCategoryId", "ShopCategoryId");
            return View();
        }

        // POST: Shops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShopId,TenCuaHang,DiaChi,LienHe,AnhDaiDien,AnhBia,NgayTao,MoTa,ShopCategoryId")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShopCategoryId"] = new SelectList(_context.ShopCategories, "ShopCategoryId", "ShopCategoryId", shop.ShopCategoryId);
            return View(shop);
        }

        // GET: Shops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops.FindAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            ViewData["ShopCategoryId"] = new SelectList(_context.ShopCategories, "ShopCategoryId", "ShopCategoryId", shop.ShopCategoryId);
            return View(shop);
        }

        // POST: Shops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShopId,TenCuaHang,DiaChi,LienHe,AnhDaiDien,AnhBia,NgayTao,MoTa,ShopCategoryId")] Shop shop)
        {
            if (id != shop.ShopId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopExists(shop.ShopId))
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
            ViewData["ShopCategoryId"] = new SelectList(_context.ShopCategories, "ShopCategoryId", "ShopCategoryId", shop.ShopCategoryId);
            return View(shop);
        }

        // GET: Shops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .Include(s => s.ShopCategories)
                .FirstOrDefaultAsync(m => m.ShopId == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        // POST: Shops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shop = await _context.Shops.FindAsync(id);
            if (shop != null)
            {
                _context.Shops.Remove(shop);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ShopId == id);
        }
    }
}
