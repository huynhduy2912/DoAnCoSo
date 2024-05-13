using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Extensions;
using DoAnNhom11.Models;
using X.PagedList;

namespace DoAnNhom11.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 7;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var applicationDbContext = await _context.Products.Include(p => p.Brand).Include(p => p.ProductCategory).AsNoTracking().OrderByDescending(x => x.ProductId).ToListAsync();
            ViewBag.categories = await _context.Categories.ToListAsync();
            ViewBag.brands = await _context.Brands.ToListAsync();
            PagedList<Product> listProduct = new PagedList<Product>(applicationDbContext, pageNumber, pageSize);
            return View(listProduct);
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            var productImages = _context.ProducImages.Where(p => p.ProductId == id).ToList();
            ViewBag.productImages = productImages;
            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "TenNhanHieu");
            ViewData["ProductCategoryId"] = new SelectList(_context.Categories, "ProductCategoryId", "TenLoai");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product, IFormFile imageUrl, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                if (imageUrl != null)
                {
                    product.AnhDaiDien = await UploadImage.SaveImage(imageUrl);
                }
                _context.Add(product);
                await _context.SaveChangesAsync();
                if (files != null)
                {
                    foreach (var file in files)
                    {
                        if (file.Length > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await file.CopyToAsync(memoryStream);
                                var image = new ProductImage
                                {
                                    Url = await UploadImage.SaveImage(file),
                                    ProductId = product.ProductId
                                };
                                _context.ProductImages.Add(image);
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId", product.BrandId);
            ViewData["ProductCategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", product.ProductCategoryId);
            return View(product);
        }
        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            var productImages = _context.ProducImages.Where(p => p.ProductId == id).ToList();
            ViewBag.productImages = productImages;
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "TenNhanHieu", product.BrandId);
            ViewData["ShopId"] = new SelectList(_context.Shops, "ShopId", "TenCuaHang", product.BrandId);
            ViewData["ProductCategoryId"] = new SelectList(_context.Categories, "ProductCategoryId", "TenLoai", product.ProductCategoryId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product, IFormFile imageUrl, List<IFormFile> files)
        {

            if (id != product.ProductId)
            {
                return NotFound();
            }
            try
            {
                if (files.Count > 0)
                {
                    var imagesToDelete = _context.ProducImages.Where(p => p.ProductId == product.ProductId);

                    if (imagesToDelete.Any())
                    {
                        _context.ProducImages.RemoveRange(imagesToDelete);
                        await _context.SaveChangesAsync();
                    }
                    foreach (var file in files)
                    {
                        if (file.Length > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await file.CopyToAsync(memoryStream);
                                var image = new ProductImage
                                {
                                    Url = await UploadImage.SaveImage(file),
                                    ProductId = product.ProductId
                                };
                                _context.ProductImages.Add(image);
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
                if (imageUrl != null)
                {
                    product.AnhDaiDien = await UploadImage.SaveImage(imageUrl);
                }
                _context.Update(product);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(product.ProductId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

            /*ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId", product.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", product.ProductCategoryId);
            return View(product);*/
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
        public async Task<IActionResult> SearchProducts(string query, int? page)
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            IQueryable<Product> productsQuery = _context.Products.Include(p => p.ProductCategory)
            .Where(p => p.TenSp.Contains(query));
            PagedList<Product> listProductQuery = new PagedList<Product>(productsQuery, pageNumber, 9);
            string viewFromAnotherController = await this.RenderViewToStringAsync("/Views/Shared/ProductListPartial.cshtml", listProductQuery);
            ViewBag.categories = await _context.Categories.ToListAsync();
            ViewBag.brands = await _context.Brands.ToListAsync();
            ViewBag.myView = viewFromAnotherController;
            ViewBag.querry = query;
            return View("Search", listProductQuery);
        }
        public List<string> SearchSuggestions(string query)
        {
            return _context.Products
            .Where(p => p.TenSp.StartsWith(query))
            .Select(p => p.TenSp)
            .ToList();

        }
    }
}
