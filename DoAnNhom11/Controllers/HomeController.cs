using DoAnNhom11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DoAnNhom11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Products.Include(p => p.Brand).Include(p => p.ProductCategory).Take(12).OrderByDescending(p => p.PhanTramGiam);
            ViewBag.itemShow1 = _context.Products.OrderBy(p => p.GiaBan).FirstOrDefault();
            ViewBag.itemShow2 = _context.Products.OrderByDescending(p => p.ProductId).FirstOrDefault();
            ViewBag.itemShow3 = _context.Products.OrderByDescending(p => p.PhanTramGiam).FirstOrDefault();

            return View(await applicationDbContext.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
