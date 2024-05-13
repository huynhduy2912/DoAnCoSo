using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;
using static NuGet.Packaging.PackagingConstants;
using Azure;
using X.PagedList;

namespace DoAnNhom11.Controllers
{
    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Details(int? ma,int? page)
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

            int totalQuantitySold = 0;
            foreach (var product in listProductByShop)
            {
                totalQuantitySold += _context.OrderDetails.Where(o => o.ProductId == product.ProductId).Sum(o => o.Quantity);
            }
            

            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            PagedList<Product> listProductByShopAndPage = new PagedList<Product>(listProductByShop, pageNumber, pageSize);

            ViewBag.TotalQuantitySold = totalQuantitySold;
            ViewBag.ProductQuantity = listProductByShop.Count();
            ViewBag.ProductList = listProductByShopAndPage;

            return View(shop);
        }

        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ShopId == id);
        }
    }
}
