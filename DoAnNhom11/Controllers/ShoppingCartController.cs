using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Extensions;
using DoAnNhom11.Models;
using System;
using System.Web;
using DoAnNhom11.Extentions;

namespace DoAnNhom11.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private static IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ShoppingCartController(UserManager<ApplicationUser> userManager,
			ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            _context= context;
            _userManager= userManager;

        }
        public async Task<IActionResult> CheckOut()
        {
            ViewData["VoucherName"] = new SelectList(_context.Vouchers, "VoucherId", "VoucherCode");
            var user = await _userManager.GetUserAsync(User);
            ViewBag.Address = user.Address;
            //Response.WriteAsync("<script>alert('Data inserted successfully')</script>");
            return View(new Order());
        }
        [HttpPost]
        public async Task<IActionResult> CheckOut(Order order)
        {
            var cart =HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            if (cart == null || !cart.Items.Any())
            {
                return RedirectToAction("Index");
            }
            var user = await _userManager.GetUserAsync(User);
            order.UserId = user.Id;
            order.OrderDate = DateTime.Now;
            order.TotalPrice = cart.Items.Sum(i => i.Price * i.Quantity);
            order.OrderStatusId = 1;
            order.OrderDetails = cart.Items.Select(i => new OrderDetail
            {
                ProductId = i.ProductId,
                Quantity = (int)i.Quantity,
                Price = i.Price
            }).ToList();
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            HttpContext.Session.Remove("Cart");
            var port = LocalHost.GetPort(_httpContextAccessor);
            //return Redirect("http://localhost:"+ port+"/Orders/Details?ma=" + order.OrderId);
            return RedirectToAction("Details","Orders", new { ma = order.OrderId });
        }
        public async Task<IActionResult> AddToCart(int productId, int quantity)
        {
            var product= await GetProductFromDatabase(productId);
            var cartItem = new CartItem()
            {
                ProductId = product.ProductId,
                ProductName = product.TenSp,
                ProductImage = product.AnhDaiDien,
                Price = product.GiaBan/100*(100-product.PhanTramGiam??0),
                Quantity = (uint)quantity,

            };
            //lưu sản phẩm trong giỏ hàng vào trong session
            var cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart") ?? new ShoppingCart();
            cart.AddItem(cartItem);
            HttpContext.Session.SetObjectAsJson("Cart", cart);
            return RedirectToAction("Index");
        }
        public ActionResult OrderCompleted()
        {
            return View();
        }
        public IActionResult Index()
        {
            
            var cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart") ?? new ShoppingCart();
            return View(cart);
        }
        public IActionResult RemoveFromCart(int productId)
        {
            var cart =HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            if (cart is not null)
            {
                cart.RemoveItem(productId);// Lưu lại giỏ hàng vào Session sau khi đã xóa mục
                HttpContext.Session.SetObjectAsJson("Cart", cart);
                
            }
            return RedirectToAction("Index");
        }
        /*public IActionResult ClearCart(string productId)
        {
            var cart =
            HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            if (cart is not null)
            {
                cart.RemoveItem(productId);// Lưu lại giỏ hàng vào Session sau khi đã xóa mục
                HttpContext.Session.SetObjectAsJson("Cart", cart);

            }
            return RedirectToAction("Index");
        }*/
        public ActionResult UpdateCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            var findCartItem = cart.Items.FirstOrDefault(i => i.ProductId == id);
            if (findCartItem != null)
            {
                findCartItem.Quantity = (uint)quantity;
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index");
        }
        public ActionResult UCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            var findCartItem = cart.Items.FirstOrDefault(i => i.ProductId == id);
            if (findCartItem != null)
            {
                findCartItem.Quantity = (uint)quantity;
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return Json(findCartItem.Quantity * findCartItem.Price);
        }
        //tìm kiếm thông tin sản phẩm từ DB
        private async Task<Product> GetProductFromDatabase(int productId)
        {
            var product= await _context.Products.Include(p =>
            p.ProductCategory).FirstOrDefaultAsync(p => p.ProductId == productId);
            return product;
        }
    }
}
