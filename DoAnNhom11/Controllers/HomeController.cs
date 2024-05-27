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
            var applicationDbContext = _context.Products.Where(p =>  p.DaAn == false).Include(p => p.Brand).Include(p => p.ProductCategory).Take(12).OrderByDescending(p => p.PhanTramGiam);
            List<Product> listItemShow = new List<Product>();
            listItemShow.Add(_context.Products.Where(p=>p.ProductId==33).FirstOrDefault());
            listItemShow.Add(_context.Products.Where(p => p.ProductId == 34).FirstOrDefault());
            listItemShow.Add(_context.Products.Where(p => p.ProductId == 35).FirstOrDefault());
            ViewBag.categories = await _context.Categories.ToListAsync();
            ViewBag.listItemShow=listItemShow;
            return View(await applicationDbContext.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
