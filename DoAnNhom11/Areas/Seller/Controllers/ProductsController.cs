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
        public async Task<IActionResult> SearchProducts(string query, int? page)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            IQueryable<Product> productsQuery = _context.Products.Where(p => p.ShopId == seller.ShopId).Where(p => p.SoLuongCon > 0).Where(p => p.DaAn == false).Include(p => p.ProductCategory)
            .Where(p => p.TenSp.Contains(query));
            PagedList<Product> listProductQuery = new PagedList<Product>(productsQuery, pageNumber, 9);
            ViewBag.categories = await _context.Categories.ToListAsync();
            ViewBag.brands = await _context.Brands.ToListAsync();
            ViewBag.querry = query;
            return View( listProductQuery);
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
               .Where(p => p.ShopId == ma).Where(p => p.SoLuongCon <= 0).Where(p=>p.DaAn==false).AsNoTracking().ToListAsync();
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
                product.SoLuongCon = 0;
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
            return RedirectToAction("HiddenProducts", "Products", new { page = 1 });

        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
        public IActionResult Excel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadProductFromExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                ViewBag.Message = "Please select a valid file.";
                return RedirectToAction("Index", "Products", new { page = 1 });
            }

            var products = new List<Product>();
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {

                    var worksheet = package.Workbook.Worksheets.First();
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var product = new Product
                        {
                            ProductId = int.TryParse(worksheet.Cells[row, 999].Text, out int productId) ? productId : 0,
                            TenSp = worksheet.Cells[row, 1].Text,
                            AnhDaiDien = worksheet.Cells[row, 2].Text,
                            MoTa = worksheet.Cells[row,3].Text,
                            ThongSo = worksheet.Cells[row, 4].Text,
                            GiaNhap = decimal.TryParse(worksheet.Cells[row, 5].Text, out decimal giaNhap) ? giaNhap : 1,
                            GiaBan = decimal.TryParse(worksheet.Cells[row,6].Text, out decimal giaBan) ? giaBan :1,
                            SoLuongCon = int.TryParse(worksheet.Cells[row, 7].Text, out int soLuongCon) ? soLuongCon : 1,
                            PhanTramGiam = int.TryParse(worksheet.Cells[row, 8].Text, out int ptg) ? ptg : (int?)null,
                            ProductCategoryId = int.TryParse(worksheet.Cells[row, 9].Text, out int productCategoryId) ? productCategoryId : 1,
                            BrandId = int.TryParse(worksheet.Cells[row, 10].Text, out int brandId) ? brandId : 1,
                            DaAn = false,
                            DiemDanhGia = 0,
                            ShopId = seller.ShopId ??0,
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



