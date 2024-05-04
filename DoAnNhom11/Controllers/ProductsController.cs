using DoAnNhom11.Extensions;
using DoAnNhom11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var applicationDbContext = await _context.Products.Include(p => p.Brand).Include(p => p.ProductCategory).AsNoTracking().OrderByDescending(x => x.ProductId).ToListAsync();
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
            var listProductByCategory = await _context.Products.Include(p => p.Brand).Include(p => p.ProductCategory).AsNoTracking().OrderByDescending(x => x.ProductId).ToListAsync();
            PagedList<Product> listProduct = new PagedList<Product>(listProductByCategory, 1, 6);
            if (categoryId > 0)
            {
                listProductByCategory = await _context.Products
               .Where(p => p.ProductCategoryId == categoryId).AsNoTracking()
               .OrderByDescending(x => x.ProductId).ToListAsync();
                listProduct = new PagedList<Product>(listProductByCategory, page, 6);
            }
            return PartialView("ProductListPartial", listProduct);
        }
        public async Task<IActionResult> GetProductsByBrand(int brandId, int page)
        {
            var listProductByCategory = await _context.Products
           .Where(p => p.BrandId == brandId).AsNoTracking()
           .OrderByDescending(x => x.ProductId).ToListAsync();
            PagedList<Product> listProduct = new PagedList<Product>(listProductByCategory, page, 6);
            return PartialView("ProductListPartial", listProduct);

        }
        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int ma)
        {
            var productReviews = _context.Reviews.Where(p => p.ProductId == ma).Include(r => r.Customer).Include(r => r.Product).ToList();
            ViewBag.productReviews = productReviews;
            var productImages = _context.ProducImages.Where(p => p.ProductId == ma).ToList();
            ViewBag.productImages = productImages;
            ViewBag.productImagesCount = productImages.Count;
            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(m => m.ProductId == ma);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
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
            //string viewFromAnotherController = await this.RenderViewToStringAsync("/Views/Shared/ProductListPartial.cshtml", listProductQuery);
            ViewBag.categories = await _context.Categories.ToListAsync();
            ViewBag.brands = await _context.Brands.ToListAsync();
            //ViewBag.myView = viewFromAnotherController;
            ViewBag.querry = query;
            return View("Search", listProductQuery);
        }
    }
}
