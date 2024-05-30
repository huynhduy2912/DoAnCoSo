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
        public async Task<IActionResult> SearchProducts(string? query)
        {   
            ViewBag.Search = query;
            return View("Search");
        }
        public async Task<IActionResult> QuerryProduct(int? page,string searchString,int? shopId,decimal? minPrice,decimal? maxPrice,int? categoryId )
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var query = _context.Products.AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                ViewBag.Search = searchString;
                query = query.Where(p => p.TenSp.Contains(searchString));
                query.Count();
            }
            if (shopId.HasValue)
            {
                query = query.Where(p => p.ShopId==shopId);
                ViewBag.ShopId = shopId;
            }
            if (minPrice.HasValue)
            {
                query = query.Where(p => (p.GiaBan / 100 * (100 - p.PhanTramGiam)) >= minPrice);
                ViewBag.MinPrice = minPrice;
            }
            if (maxPrice.HasValue)
            {
                query = query.Where(p => (p.GiaBan / 100 * (100 - p.PhanTramGiam)) <= maxPrice);
                ViewBag.MaxPrice = maxPrice;

            }
            if (categoryId.HasValue)
            {
                query = query.Where(p => p.ProductCategoryId==categoryId);
                ViewBag.CategoryId = categoryId;
            }
            query = query.Where(p => p.SoLuongCon >0).Where(p => p.DaAn != true).OrderByDescending(p=>p.ProductId);
            var categories = await _context.Categories
                                        .Where(c => query.Select(p => p.ProductCategoryId).Distinct().Contains(c.ProductCategoryId))
                                        .ToListAsync();
            if(categories.Count > 1)
            {
                ViewBag.myViewCategory = await this.RenderViewToStringAsync("/Views/Shared/_ListCategoryPartial.cshtml", categories);
            }
            else
            {
                ViewBag.myViewCategory = 0;
            }

            var productByPages = await query.ToPagedListAsync(pageNumber, 9);
            
            return PartialView("_ListProductPartial", productByPages);
        }
       
        public async Task<IActionResult> Category(int? categoryId)
        {
            if (categoryId == null)
            {
                return NotFound();
            }

            var productCategory = await _context.Categories
                .FirstOrDefaultAsync(m => m.ProductCategoryId == categoryId);
            if (productCategory == null)
            {
                return NotFound();
            }

            return View(productCategory);
        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

    }
}
