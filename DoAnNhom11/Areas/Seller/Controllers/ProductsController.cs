using DoAnNhom11.Extensions;
using DoAnNhom11.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using X.PagedList;

namespace DoAnNhom11.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize]



    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationUser? seller;
        public ProductsController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index(int? page)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int ma = seller.ShopId ?? 0;
            if (ma == 0)
            {
                return NotFound();
            }
            var listProductByShop = await _context.Products
               .Where(p => p.ShopId == ma).Where(p => p.DaAn == false).Where(p => p.SoLuongCon > 0).AsNoTracking().ToListAsync();
            listProductByShop.Reverse();
            int pageSize = 5;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            PagedList<Product> listProductByShopAndPage = new PagedList<Product>(listProductByShop, pageNumber, pageSize);
            return View(listProductByShopAndPage);
        }
        public async Task<IActionResult> HiddenProducts(int? page)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int ma = seller.ShopId ?? 0;
            if (ma == 0)
            {
                return NotFound();
            }
            var listProductByShop = await _context.Products
               .Where(p => p.ShopId == ma).Where(p => p.DaAn == true).AsNoTracking().ToListAsync();
            listProductByShop.Reverse();
            int pageSize = 5;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            PagedList<Product> listProductByShopAndPage = new PagedList<Product>(listProductByShop, pageNumber, pageSize);
            return View(listProductByShopAndPage);
        }
        public async Task<IActionResult> SoldOutProducts(int? page)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int ma = seller.ShopId ?? 0;
            if (ma == 0)
            {
                return NotFound();
            }
            var listProductByShop = await _context.Products
               .Where(p => p.ShopId == ma).Where(p => p.SoLuongCon <= 0).AsNoTracking().ToListAsync();
            listProductByShop.Reverse();
            int pageSize = 5;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            PagedList<Product> listProductByShopAndPage = new PagedList<Product>(listProductByShop, pageNumber, pageSize);
            return View(listProductByShopAndPage);
        }
        public async Task<IActionResult> AddProduct()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            ViewBag.ShopId = seller.ShopId ?? 0;
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "TenNhanHieu");
            ViewData["ProductCategoryId"] = new SelectList(_context.Categories, "ProductCategoryId", "TenLoai");
            return View();
        }

        
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
                return RedirectToAction("Details", "Products", new { id = product.ProductId });

            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId", product.BrandId);
            ViewData["ProductCategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", product.ProductCategoryId);
            return View(product);
        }
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
            return RedirectToAction("Details", "Products", new { id = product.ProductId });
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
                product.DaAn = true;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Products", new { page = 1 });

        }
        public async Task<IActionResult> ShowProduct(int? id)
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
        [HttpPost, ActionName("ShowProduct")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShowProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                product.DaAn = false;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("HiddenProducts", "Products", new {  page = 1 });

        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
        [HttpGet]
        public IActionResult UploadExcel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadExcel(dynamic model)
        {
            if (model.ExcelFile == null || model.ExcelFile.Length == 0)
            {
                ModelState.AddModelError("", "Please select a valid Excel file.");
                return View();
            }

            var products = new List<Product>();

            using (var stream = new MemoryStream())
            {
                await model.ExcelFile.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var product = new Product
                        {
                            ProductId = int.Parse(worksheet.Cells[row, 1].Value.ToString().Trim()),
                            TenSp = worksheet.Cells[row, 2].Value.ToString().Trim(),
                            AnhDaiDien = worksheet.Cells[row, 3].Value?.ToString().Trim(),
                            MoTa = worksheet.Cells[row, 4].Value?.ToString().Trim(),
                            ThongSo = worksheet.Cells[row, 5].Value?.ToString().Trim(),
                            GiaNhap = decimal.Parse(worksheet.Cells[row, 6].Value.ToString().Trim()),
                            GiaBan = decimal.Parse(worksheet.Cells[row, 7].Value.ToString().Trim()),
                            SoLuongCon = int.Parse(worksheet.Cells[row, 8].Value.ToString().Trim()),
                            PhanTramGiam = worksheet.Cells[row, 9].Value != null ? (int?)int.Parse(worksheet.Cells[row, 9].Value.ToString().Trim()) : null,
                            DiemDanhGia = worksheet.Cells[row, 10].Value != null ? (int?)int.Parse(worksheet.Cells[row, 10].Value.ToString().Trim()) : null,
                            DaAn = bool.Parse(worksheet.Cells[row, 11].Value.ToString().Trim()),
                            ProductCategoryId = int.Parse(worksheet.Cells[row, 12].Value.ToString().Trim()),
                            BrandId = int.Parse(worksheet.Cells[row, 13].Value.ToString().Trim()),
                            ShopId = int.Parse(worksheet.Cells[row, 14].Value.ToString().Trim())
                        };

                        products.Add(product);
                    }
                }
            }

            _context.Products.AddRange(products);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Products", new { page = 1 });

        }


    }
}


