using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;
using DoAnNhom11.Extensions;
using Microsoft.CodeAnalysis;
using Azure;
using X.PagedList;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Build.Evaluation;

namespace DoAnNhom11.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize]
    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationUser? seller;
        public ShopsController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }

        // GET: Seller/Shops
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Shops.Include(s => s.ShopCategories);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Seller/Shops/Edit/5
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
            ViewData["ShopCategoryId"] = new SelectList(_context.ShopCategories, "ShopCategoryId", "TenLoai", shop.ShopCategoryId);
            return View(shop);
        }

        // POST: Seller/Shops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Shop shop, IFormFile imageAvatar, IFormFile imageBackground)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int id = seller.ShopId ?? 1;
            if (id != shop.ShopId)
            {
                return NotFound();
            }
            try
            {
                if (imageAvatar != null)
                {
                    shop.AnhDaiDien = await UploadImage.SaveImage(imageAvatar);
                }

                if (imageBackground != null)
                {
                    shop.AnhBia = await UploadImage.SaveImage(imageBackground);
                }

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
            ViewData["ShopCategoryId"] = new SelectList(_context.ShopCategories, "ShopCategoryId", "ShopCategoryId", shop.ShopCategoryId);
            return RedirectToAction("Index");
        }

        // GET: Admin/Products/Create
        public async Task<IActionResult> AddProduct()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            ViewBag.ShopId = seller.ShopId ?? 1;
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "TenNhanHieu");
            ViewData["ProductCategoryId"] = new SelectList(_context.Categories, "ProductCategoryId", "TenLoai");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProduct(Product product, IFormFile imageUrl, List<IFormFile> files)
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
                return RedirectToAction("Products", "Shops", new { ma = product.ShopId, page = 1 });

            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId", product.BrandId);
            ViewData["ProductCategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", product.ProductCategoryId);
            return View(product);
        }
        public async Task<IActionResult> Orders(int? page)
        {
            int pageSize = 9;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var user = await _userManager.GetUserAsync(User);
            var applicationDbContext = await _context.Orders.Where(p => p.OrderDetails[0].Product.ShopId == user.ShopId && p.OrderStatusId != 6).Include(o => o.ApplicationUser).Include(o => o.VouCher).Include(o => o.OrderStatus).ToListAsync();
            applicationDbContext.Reverse();
            PagedList<Order> listOrder = new PagedList<Order>(applicationDbContext, pageNumber, pageSize);
            return View(listOrder);
        }
        public async Task<IActionResult> CanceledOrders(int? page)
        {
            int pageSize = 9;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var user = await _userManager.GetUserAsync(User);
            var applicationDbContext = await _context.Orders.Where(p => p.OrderDetails[0].Product.ShopId == user.ShopId && p.OrderStatusId == 6).Include(o => o.ApplicationUser).Include(o => o.VouCher).Include(o => o.OrderStatus).ToListAsync();
            applicationDbContext.Reverse();
            PagedList<Order> listOrder = new PagedList<Order>(applicationDbContext, pageNumber, pageSize);
            return View(listOrder);
        }
        public async Task<IActionResult> OrderDetails(int ma)
        {
            var applicationDbContext = await _context.OrderDetails.Where(p => p.OrderId == ma).Include(o => o.Order).Include(o => o.Product).Include(o => o.Product).ToListAsync();
            ViewBag.OrderDetails = applicationDbContext;
            var order = await _context.Orders
                .Include(o => o.ApplicationUser)
                .Include(o => o.OrderStatus)
                .Include(o => o.VouCher)
                .Include(o => o.Payment)
                .FirstOrDefaultAsync(m => m.OrderId == ma);
            ViewData["OrderStatusId"] = new SelectList(_context.OrderStatuses, "OrderStatusId", "TenTrangThai", order.OrderStatusId);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateOrder(int orderStatusId,int orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(m => m.OrderId == orderId);
            order.OrderStatusId= orderStatusId;
            await _context.SaveChangesAsync();

            return RedirectToAction("Orders", "Shops", new {  page = 1 });
        }
        public async Task<IActionResult> Products(int? page)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int ma = seller.ShopId ?? 1;
            var listProductByShop = await _context.Products
               .Where(p => p.ShopId == ma).AsNoTracking().ToListAsync();
            listProductByShop.Reverse();
            int pageSize = 5;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            PagedList<Product> listProductByShopAndPage = new PagedList<Product>(listProductByShop, pageNumber, pageSize);
            return View(listProductByShopAndPage);
        }
        public async Task<IActionResult> EditProduct(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var productImages = _context.ProducImages.Where(p => p.ProductId == id).ToList();
            ViewBag.productImages = productImages;
            var product = await _context.Products.FindAsync(id);
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            if (seller.ShopId != product.ShopId)
            {
                return Content("Sản phẩm không tồn tại trong cửa hàng");
            }
            if (product == null)
            {
                return NotFound();
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "TenNhanHieu", product.BrandId);
            ViewData["ShopId"] = new SelectList(_context.Shops, "ShopId", "TenCuaHang", product.BrandId);
            ViewData["ProductCategoryId"] = new SelectList(_context.Categories, "ProductCategoryId", "TenLoai", product.ProductCategoryId);
            return View(product);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(int id, Product product, IFormFile imageUrl, List<IFormFile> files)
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
            return RedirectToAction("Products", "Shops", new { ma = product.ShopId, page = 1 });


            /*ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId", product.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", product.ProductCategoryId);
            return View(product);*/
        }

        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            if (seller.ShopId != product.ShopId)
            {
                return Content("Sản phẩm không tồn tại trong cửa hàng");
            }
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Products", "Shops", new { ma = product.ShopId, page = 1 });

        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ShopId == id);
        }
    }
}
