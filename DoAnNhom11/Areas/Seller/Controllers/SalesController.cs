using DoAnNhom11.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DoAnNhom11.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize(Roles = "Developer,ShopStaff,ShopOwner")]


    public class SalesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationUser? seller;
        public SalesController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Analysis()
        {

            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = await _context.Orders.Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId).Include(o => o.ApplicationUser).Include(o => o.VouCher).Include(o => o.OrderStatus).ToListAsync();


            return View(applicationDbContext);
        }
        public async Task<IActionResult> Chart()
        {
            return View();
        }
        public async Task<IActionResult> OrderAnalysis()
        {
            return View();
        }
        public async Task<IActionResult> RevenueAnalysis()
        {
            return View();
        }
        public async Task<IActionResult> ProductAnalysis()
        {
            return View();
        }
        public async Task<IActionResult> OrderAnalyze()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = await _context.Orders.Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId).Include(o => o.ApplicationUser).Include(o => o.VouCher).Include(o => o.OrderStatus).ToListAsync();
            ViewBag.Don = applicationDbContext
                .Count();
            ViewBag.DonChoXacNhan = applicationDbContext
                .Count(o => o.OrderStatusId == 1);
            ViewBag.DonDaThanhToan = applicationDbContext
                .Count(o => o.OrderStatusId == 5);

            ViewBag.DonHomNay = applicationDbContext
                .Count(o => o.OrderDate.Date == DateTime.Today);
            ViewBag.DonChoXacNhanHomNay = applicationDbContext
                .Count(o => o.OrderStatusId == 1 && o.OrderDate.Date == DateTime.Today);
            ViewBag.DonDaThanhToanHomNay = applicationDbContext
                .Count(o => o.OrderStatusId == 5 && o.OrderDate.Date == DateTime.Today);

            ViewBag.DonHomQua = applicationDbContext
                .Count(o => o.OrderDate.Date == DateTime.Today.AddDays(-1));
            ViewBag.DonChoXacNhanHomQua = applicationDbContext
                .Count(o => o.OrderStatusId == 1 && o.OrderDate.Date == DateTime.Today.AddDays(-1));
            ViewBag.DonDaThanhToanHomQua = applicationDbContext
                .Count(o => o.OrderStatusId == 5 && o.OrderDate.Date == DateTime.Today.AddDays(-1));

            ViewBag.DonTuanNay = applicationDbContext
                .Count(o => o.OrderDate.Date >= DateTime.Today.AddDays(-7));
            ViewBag.DonChoXacNhanTuanNay = applicationDbContext
                .Count(o => o.OrderStatusId == 1 && o.OrderDate.Date >= DateTime.Today.AddDays(-7));
            ViewBag.DonDaThanhToanTuanNay = applicationDbContext
                .Count(o => o.OrderStatusId == 5 && o.OrderDate.Date >= DateTime.Today.AddDays(-7));

            ViewBag.DonThangNay = applicationDbContext
                .Count(o => o.OrderDate.Date >= DateTime.Today.AddDays(-30));
            ViewBag.DonChoXacNhanThangNay = applicationDbContext
                .Count(o => o.OrderStatusId == 1 && o.OrderDate.Date >= DateTime.Today.AddDays(-30));
            ViewBag.DonDaThanhToanThangNay = applicationDbContext
                .Count(o => o.OrderStatusId == 5 && o.OrderDate.Date >= DateTime.Today.AddDays(-30));


            return PartialView("/Areas/Seller/Views/Sales/_OrderAnalyzePartial.cshtml");
        }
        public async Task<IActionResult> RevenueAnalyze()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = await _context.Orders.
                Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId)
                .Include(o => o.ApplicationUser).Include(o => o.VouCher)
                .Include(o => o.OrderStatus)
                .ToListAsync();
            ViewBag.doanhThu = applicationDbContext
                .Where(o => o.OrderStatusId == 5)
                .Sum(o => o.TotalPrice);
            ViewBag.doanhThuHomNay = applicationDbContext
                .Where(o => o.OrderStatusId == 5 && o.OrderDate.Date == DateTime.Today)
                .Sum(o => o.TotalPrice);
            ViewBag.doanhThuHomQua = applicationDbContext
                .Where(o => o.OrderStatusId == 5 && o.OrderDate.Date == DateTime.Today.AddDays(-1))
                .Sum(o => o.TotalPrice);
            ViewBag.doanhThuTuanNay = applicationDbContext
                .Where(o => o.OrderStatusId == 5 && o.OrderDate.Date >= DateTime.Today.AddDays(-7))
                .Sum(o => o.TotalPrice);
            ViewBag.doanhThuThangNay = applicationDbContext
                .Where(o => o.OrderStatusId == 5 && o.OrderDate.Date >= DateTime.Today.AddDays(-30))
                .Sum(o => o.TotalPrice);
            return PartialView("/Areas/Seller/Views/Sales/_RevenueAnalyzePartial.cshtml");

        }
        public async Task<IActionResult> ProductAnalyze()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var topSaleProducts = _context.Products.Where(p => p.ShopId == seller.ShopId)
            .Select(p => new
            {
                p.TenSp,
                p.SoLuongCon,
                p.AnhDaiDien,
                p.PhanTramGiam,
                p.GiaBan,
                p.DiemDanhGia,
                SoLuongBan = p.OrderDetails.Sum(o => o.Quantity)
            })
            .OrderByDescending(p => p.SoLuongBan)
            .Take(5)
            .Where(p => p.SoLuongBan != 0)
            .ToList();
            var topRevenueProducts = _context.Products.Where(p => p.ShopId == seller.ShopId)
            .Select(p => new
            {
                p.TenSp,
                p.SoLuongCon,
                p.AnhDaiDien,
                p.PhanTramGiam,
                p.GiaBan,
                p.DiemDanhGia,
                DoanhThu = p.OrderDetails.Where(o => o.Order.OrderStatusId == 5).Sum(o => o.Product.GiaBan*o.Quantity/100*(100-o.Order.VouCher.PhanTramGiam))
            })
            .OrderByDescending(p => p.DoanhThu)
            .Take(5)
            .Where(p => p.DoanhThu != 0)
            .ToList();
            ViewBag.topSaleProducts = topSaleProducts;
            ViewBag.topRevenueProducts = topRevenueProducts;
            return PartialView("/Areas/Seller/Views/Sales/_ProductAnalyzePartial.cshtml");
        }

        [HttpGet]
        public async Task<IActionResult> GetOrdersData(int querry)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = new List<Order>();
            if (querry == 1)
            {
                applicationDbContext = await _context.Orders
                    .Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId)
                    .ToListAsync();
            }else if(querry == 2)
            {
                applicationDbContext = await _context.Orders
                    .Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId)
                    .Where(o => o.OrderDate.Date >= DateTime.Today.AddDays(-30))
                    .ToListAsync();
            }else if(querry == 3)
            {
                applicationDbContext = await _context.Orders
                    .Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId)
                    .Where(o => o.OrderDate.Date >= DateTime.Today.AddDays(-365))
                    .ToListAsync();
            }
            var orders = applicationDbContext
                .GroupBy(o => o.OrderDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    Quantity = g.Count(),
                })
                .ToList();

            return Json(orders);
        }    
        [HttpGet]
        public async Task<IActionResult> GetRevenuesData(int querry)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = new List<Order>();
            if (querry == 1)
            {
                applicationDbContext = await _context.Orders
                    .Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId)
                    .Where(o => o.OrderStatusId == 5)
                    .ToListAsync();
            }
            else if (querry == 2)
            {
                applicationDbContext = await _context.Orders
                    .Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId)
                    .Where(o => o.OrderDate.Date >= DateTime.Today.AddDays(-30))
                    .Where(o=>o.OrderStatusId==5)
                    .ToListAsync();
            }
            else if (querry == 3)
            {
                applicationDbContext = await _context.Orders
                    .Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId)
                    .Where(o => o.OrderDate.Date >= DateTime.Today.AddDays(-365))
                    .Where(o => o.OrderStatusId == 5)
                    .ToListAsync();
            }
            var orders = applicationDbContext
                .GroupBy(o => o.OrderDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    Revenue=  g.Sum(o => o.TotalPrice)
                })
                .ToList();

            return Json(orders);
        }
        public async Task<IActionResult> GetProductCategoryChartData()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var categories = _context.Categories
             .Where(c => c.Products != null &&c.Products.Any(p => p.ShopId == seller.ShopId && p.SoLuongCon != 0 && p.DaAn == false))
             .Include(p=>p.Products)
             .ToList();


            var data = categories.Select(c => c.Products.Count(p => p.ShopId == seller.ShopId&&p.SoLuongCon!=0&&p.DaAn==false)).ToList();
            var labels = categories.Select(c => c.TenLoai).ToList();

            var chartData = new { data = data, labels = labels };

            return Json(chartData);
        }
    }
}

