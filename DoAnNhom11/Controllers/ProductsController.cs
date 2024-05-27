using DoAnNhom11.Extensions;
using DoAnNhom11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using X.PagedList;

namespace DoAnNhom11.Controllers
{
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
            int pageSize = 9;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var applicationDbContext = await _context.Products.Where(p => p.DaAn == false && p.SoLuongCon != 0).Include(p => p.Brand).Include(p => p.ProductCategory).AsNoTracking().OrderByDescending(x => x.ProductId).ToListAsync();
            ViewBag.categories = await _context.Categories.ToListAsync();
            ViewBag.brands = await _context.Brands.ToListAsync();
            PagedList<Product> listProduct = new PagedList<Product>(applicationDbContext, pageNumber, pageSize);
            /* string viewFromAnotherController = await this.RenderViewToStringAsync("/Views/Shared/ProductListPartial.cshtml", listProduct);
             ViewBag.myView = viewFromAnotherController;*/
            return View(listProduct);
        }
        public List<string> SearchSuggestions(string query)
        {
            return _context.Products
            .Where(p => p.TenSp.StartsWith(query))
            .Select(p => p.TenSp)
            .ToList();

        }
        public async Task<IActionResult> GetProductsByCategory(int categoryId, int page)
        {
            var listProductByCategory = await _context.Products.Where(p => p.SoLuongCon > 0).Where(p => p.DaAn == false).Include(p => p.Brand).Include(p => p.ProductCategory).AsNoTracking().OrderByDescending(x => x.ProductId).ToListAsync();
            PagedList<Product> listProduct = new PagedList<Product>(listProductByCategory, 1, 6);
            if (categoryId > 0)
            {
                listProductByCategory = await _context.Products.Where(p => p.SoLuongCon > 0)
               .Where(p => p.ProductCategoryId == categoryId).AsNoTracking()
               .OrderByDescending(x => x.ProductId).ToListAsync();
                listProduct = new PagedList<Product>(listProductByCategory, page, 6);
            }
            return PartialView("ProductListPartial", listProduct);
        }
        public async Task<IActionResult> GetProductsByBrand(int brandId, int page)
        {
            var listProductByCategory = await _context.Products
           .Where(p => p.BrandId == brandId).Where(p => p.SoLuongCon > 0).Where(p => p.DaAn == false).AsNoTracking()
           .OrderByDescending(x => x.ProductId).ToListAsync();
            PagedList<Product> listProduct = new PagedList<Product>(listProductByCategory, page, 6);
            return PartialView("ProductListPartial", listProduct);
        }
        public async Task<IActionResult> Details(int ma)
        {

            var productImages = _context.ProducImages.Where(p => p.ProductId == ma).ToList();
            ViewBag.productImages = productImages;
            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.ProductCategory)
                .Include(p => p.Shop)
                .FirstOrDefaultAsync(m => m.ProductId == ma);
            if (product == null)
            {
                return NotFound();
            }
            var productReviews = await _context.Reviews.Where(p => p.ProductId == ma).Include(r => r.Customer).Include(r => r.Product).ToListAsync();
            foreach (var productReview in productReviews)
            {
                var reviewImage = _context.ReviewsImage.Where(p => p.ReviewsId == productReview.ReviewsId).ToList();
            }
            ViewBag.productReviews = productReviews;
            return View(product);
        }
        public async Task<IActionResult> SearchProducts(string query, int? page)
        {   
            ViewBag.Search = query;
            return View("Search");
        }
        public async Task<IActionResult> QuerryProduct(int? page,string searchString,decimal? minPrice,decimal? maxPrice,int? categoryId )
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var query = _context.Products.AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(p => p.TenSp.Contains(searchString));
            }
            if (minPrice.HasValue)
            {
                query = query.Where(p => (p.GiaBan / 100 * (100 - p.PhanTramGiam)) >= minPrice);
            }
            if (maxPrice.HasValue)
            {
                query = query.Where(p => (p.GiaBan / 100 * (100 - p.PhanTramGiam)) <= maxPrice);
            }
            ViewBag.MinPrice = minPrice;
            ViewBag.MaxPrice = maxPrice;
            ViewBag.Search= searchString;
            //query = query.Where(p => p.DaAn != true);
            query = query.Where(p => p.SoLuongCon >0);

            var products = await query.ToPagedListAsync(pageNumber, 9);     
            return PartialView("_ListSearchPartial", products);
        }
       
        public async Task<IActionResult> Category(int categoryId, int page)
        {
            var listProductByCategory = await _context.Products
            .Where(p => p.SoLuongCon > 0)
            .Where(p => p.DaAn == false)
           .Where(p => p.ProductCategoryId == categoryId).Include(p => p.ProductCategory).AsNoTracking()
           .OrderByDescending(x => x.ProductId).ToListAsync();
            if(listProductByCategory.Count == 0)
            {
                return Content("<center><h1>Loại sản phẩm này đã hết hàng<h1><button onclick=\"window.history.back()\">Trở về</button></center>", "text/html", System.Text.Encoding.UTF8);
            }
            PagedList<Product> listProduct = new PagedList<Product>(listProductByCategory, page, 8);
            return View(listProduct);
        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

    }
}
