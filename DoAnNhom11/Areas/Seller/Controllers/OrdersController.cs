using DoAnNhom11.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace DoAnNhom11.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationUser? seller;
        public OrdersController(UserManager<ApplicationUser> userManager,
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
            int pageSize = 9;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var applicationDbContext = await _context.Orders
                .Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId && p.OrderStatusId != 6)
                .Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .Include(o => o.VouCher)
                .Include(o => o.OrderStatus)
                .ToListAsync();
            applicationDbContext.Reverse();
            PagedList<Order> listOrder = new PagedList<Order>(applicationDbContext, pageNumber, pageSize);
            return View(listOrder);
        }
        public async Task<IActionResult> OrdersNotConfirm(int? page)
        {
            
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int pageSize = 9;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var applicationDbContext = await _context.Orders
                .Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId && p.OrderStatusId == 1)
                .Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .Include(o => o.VouCher)
                .Include(o => o.OrderStatus)
                .ToListAsync();
            applicationDbContext.Reverse();
            PagedList<Order> listOrder = new PagedList<Order>(applicationDbContext, pageNumber, pageSize);
            return View(listOrder);
        }
        public async Task<IActionResult> CanceledOrders(int? page)
        {
            int pageSize = 9;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = await _context.Orders.Where(p => p.OrderDetails[0].Product.ShopId == seller.ShopId && p.OrderStatusId == 6)
                .Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .Include(o => o.VouCher)
                .Include(o => o.OrderStatus)
                .ToListAsync();
            applicationDbContext.Reverse();
            PagedList<Order> listOrder = new PagedList<Order>(applicationDbContext, pageNumber, pageSize);
            return View(listOrder);
        }
        public async Task<IActionResult> OrderDetails(int ma)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var orderdetails = await _context.OrderDetails.Where(p => p.OrderId == ma).Include(o => o.Order).Include(o => o.Product).Include(o => o.Product).ToListAsync();
            if (orderdetails[0].Product.ShopId != seller.ShopId)
            {
                return Content("Đơn hàng không tồn tại");
            }
            ViewBag.OrderDetails = orderdetails;
            var order = await _context.Orders
                .Include(o => o.ApplicationUser)
                .Include(o => o.OrderStatus)
                .Include(o => o.VouCher)
                .Include(o => o.Payment)
                .FirstOrDefaultAsync(m => m.OrderId == ma);
            
            ViewBag.OrderStatus=await _context.OrderStatuses.Select(p=>p.TenTrangThai).ToListAsync();
            ViewBag.CustomerInfo= await _userManager.FindByIdAsync(order.UserId);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateOrder(int orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(m => m.OrderId == orderId);
            if (order.OrderStatusId < 5)
            {
                order.OrderStatusId++;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("OrderDetails", "Orders", new { ma = order.OrderId });
        }

    }
}
