using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Azure;
using X.PagedList;
using DoAnNhom11.Extensions;

namespace DoAnNhom11.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public OrdersController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 9;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var user = await _userManager.GetUserAsync(User);
            var applicationDbContext = await _context.Orders.Where(p => p.UserId == user.Id).Include(o => o.ApplicationUser).Include(o => o.VouCher).Include(o => o.OrderStatus).ToListAsync();
            applicationDbContext.Reverse();
            PagedList<Order> listOrder = new PagedList<Order>(applicationDbContext, pageNumber, pageSize);
            return View(listOrder);
        }

        public async Task<IActionResult> Details(int ma)
        {
            var applicationDbContext = await _context.OrderDetails.Where(p => p.OrderId == ma).Include(o => o.Order).Include(o => o.Product).ToListAsync();
            ViewBag.OrderDetails = applicationDbContext;
            var order = await _context.Orders
                .Include(o => o.ApplicationUser)
                .Include(o => o.OrderStatus)
                .Include(o => o.VouCher)
                .Include(o => o.Payment)
                .FirstOrDefaultAsync(m => m.OrderId == ma);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        public async Task<IActionResult> OrderManager(int? id)
        {

            var applicationDbContext = await _context.Orders.Include(o => o.ApplicationUser).Include(o => o.VouCher).Include(o => o.OrderStatus).ToListAsync();
            return View(applicationDbContext);
        }
        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", order.UserId);
            ViewData["OrderStatusId"] = new SelectList(_context.OrderStatuses, "OrderStatusId", "OrderStatusId", order.OrderStatusId);
            ViewData["VoucherId"] = new SelectList(_context.Vouchers, "VoucherId", "VoucherId", order.VoucherId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,OrderDate,TotalPrice,ShippingAddress,Notes,VoucherId,OrderStatusId,UserId")] Order order)
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

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {

                order.OrderStatusId = 6;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReviews(string? noiDung,int diem,int productId,int orderId, List<IFormFile> myFile)
        {

            Reviews reviews =new Reviews();
            reviews.NoiDung = noiDung??" ";
            reviews.DiemDanhGia = diem;
            reviews.ThoiGianDanhGia=DateTime.Now;
            reviews.ProductId = productId;
            var user = await _userManager.GetUserAsync(User);
            reviews.CustomerId= user.Id;
            if (ModelState.IsValid)
            {
                
                var order = await _context.OrderDetails.Where(p => p.OrderId == orderId && p.ProductId == productId).FirstOrDefaultAsync();
                order.IsReview = 1;
                _context.Add(reviews);
                await _context.SaveChangesAsync();
                if (myFile != null)
                {
                    foreach (var file in myFile)
                    {
                        if (file.Length > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await file.CopyToAsync(memoryStream);
                                var image = new ReviewsImage
                                {
                                    Url = await UploadImage.SaveImage(file),
                                    ReviewsId = reviews.ReviewsId
                                };
                                _context.ReviewsImage.Add(image);
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
                return RedirectToAction("Details", "Products", new { ma = productId });

            }
            return Content("Lỗi");
        }
        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
