using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

using DoAnNhom11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoAnNhom11.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public OrdersController( UserManager<ApplicationUser> userManager,ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index(int? id)
        {

            var user = await _userManager.GetUserAsync(User);
            var applicationDbContext = await _context.Orders.Where(p => p.UserId == user.Id).Include(o => o.ApplicationUser).Include(o => o.VouCher).Include(o => o.OrderStatus).ToListAsync();
            return View(applicationDbContext);
        }

        public async Task<IActionResult> Details(int ma)
        {
            var applicationDbContext = _context.OrderDetails.Where(p => p.OrderId == ma).Include(o => o.Order).Include(o => o.Product);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> OrderManager(int? id)
        {

            var applicationDbContext = await _context.Orders.Include(o => o.ApplicationUser).Include(o => o.VouCher).Include(o => o.OrderStatus).ToListAsync();
            return View(applicationDbContext);
        }
        public async Task<IActionResult> Edit(int ma)
        {
            var order = await _context.Orders.FindAsync(ma);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", order.UserId);
            ViewData["OrderStatusId"] = new SelectList(_context.OrderStatuses, "OrderStatusId", "TenTrangThai", order.OrderStatusId);
            ViewData["VoucherId"] = new SelectList(_context.Vouchers, "VoucherId", "VoucherCode", order.VoucherId);
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editt(int id, [Bind("OrderId,OrderDate,TotalPrice,ShippingAddress,Notes,VoucherId,OrderStatusId,UserId")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", order.UserId);
            ViewData["OrderStatusId"] = new SelectList(_context.OrderStatuses, "OrderStatusId", "OrderStatusId", order.OrderStatusId);
            ViewData["VoucherId"] = new SelectList(_context.Vouchers, "VoucherId", "VoucherId", order.VoucherId);
            return View(order);
        }
        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
