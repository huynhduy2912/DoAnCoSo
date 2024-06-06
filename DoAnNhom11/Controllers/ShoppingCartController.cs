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
    [Authorize(Roles = "Developer,Customer")]

    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ShoppingCartController(UserManager<ApplicationUser> userManager,
			ApplicationDbContext context)
        {
            _context= context;
            _userManager= userManager;

        }
        public IActionResult Index()
        {
            var listCart = HttpContext.Session.GetObjectFromJson<List<ShoppingCart>>("Cart") ?? new List<ShoppingCart>();
            return View(listCart);
        }
        public async Task<IActionResult> CheckOut(int shopId)
        {
            var applicationDbContext = _context.Vouchers.Where(v=>v.SoLuongCon>0&&v.NgayHetHan>DateTime.Now&&(v.ShopId==shopId||v.ShopId==-1)).Include(v => v.VoucherCategory);
            ViewBag.Voucher = applicationDbContext;
            ViewData["Payment"] = new SelectList(_context.Payments, "PaymentId", "TenLoai");
            var listCart = HttpContext.Session.GetObjectFromJson<List<ShoppingCart>>("Cart") ?? new List<ShoppingCart>();
            var cart = GetShoppingCartByShopId(listCart, shopId);
            ViewBag.Cart = cart;
            var user = await _userManager.GetUserAsync(User);
            ViewBag.Address = user.Address;
            return View(new Order());
        }
        [HttpPost]
        public async Task<IActionResult> CheckOut(Order order,int shopId,int? voucherId,string specificAddress)
        {
            var listCart = HttpContext.Session.GetObjectFromJson<List<ShoppingCart>>("Cart") ?? new List<ShoppingCart>();
            var cart = GetShoppingCartByShopId(listCart, shopId);
            if (cart == null || !cart.Items.Any())
            {
                return RedirectToAction("Index");
            }
            var voucher = await _context.Vouchers.FirstOrDefaultAsync(m => m.VoucherId == voucherId);
            var user = await _userManager.GetUserAsync(User);
            order.UserId = user.Id;
            order.OrderDate = DateTime.Now;
            order.VoucherId = voucherId;
            decimal cartPrice = cart.Items.Sum(i => i.Price * i.Quantity); 
            decimal decreasePrice=cartPrice/100*voucher.PhanTramGiam;
            if (decreasePrice > voucher.GiamToiDa&&voucher.GiamToiDa>0)
            {
                decreasePrice = voucher.GiamToiDa??decreasePrice;
            }
            order.TotalPrice = cartPrice-decreasePrice;
            order.ShippingAddress = specificAddress + ", " + order.ShippingAddress;
            order.OrderStatusId = 1;
            foreach (var item in cart.Items)
            {
                Product _product = _context.Products.FirstOrDefault(p => p.ProductId == item.ProductId);
                if (_product.SoLuongCon > 0)
                {
                    _product.SoLuongCon-=(int)item.Quantity;
                }

            }
            order.OrderDetails = cart.Items.Select(i => new OrderDetail
            {
                ProductId = i.ProductId,
                Quantity = (int)i.Quantity,
                Price = i.Price
            }).ToList();
            
            if (voucher.VoucherId != 1 && voucher.SoLuongCon > 0)
            {
                voucher.SoLuongCon--;
            }
            _context.Orders.Add(order);


            await _context.SaveChangesAsync();
            listCart.Remove(cart);
            HttpContext.Session.SetObjectAsJson("Cart", listCart);
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
            var listCart = HttpContext.Session.GetObjectFromJson<List<ShoppingCart>>("Cart") ?? new List<ShoppingCart>();
            if (listCart.Count < 1)
            {
                ShoppingCart newShoppingCart = new ShoppingCart();
                newShoppingCart.shopName = product.Shop.TenCuaHang;
                newShoppingCart.shopId = product.Shop.ShopId;
                newShoppingCart.AddItem(cartItem);
                listCart.Add(newShoppingCart);
            }
            else
            {
                if (isShopExist(listCart,product.Shop.TenCuaHang,cartItem)) {
                    HttpContext.Session.SetObjectAsJson("Cart", listCart);
                    return RedirectToAction("Index"); ;
                }
                else
                {
                    ShoppingCart newShoppingCart = new ShoppingCart();
                    newShoppingCart.shopName= product.Shop.TenCuaHang;
                    newShoppingCart.shopId = product.Shop.ShopId;

                    newShoppingCart.AddItem(cartItem);
                    listCart.Add(newShoppingCart);
                }
            }
            HttpContext.Session.SetObjectAsJson("Cart", listCart);
            return RedirectToAction("Index");
        }
        public bool isShopExist(List<ShoppingCart> listCart,string shopName,CartItem cartItem)
        {
            foreach (var item in listCart)
            {
                if (item.shopName == shopName)
                {
                    item.AddItem(cartItem);
                    return true;
                }
            }
            return false;
        }
        public ActionResult OrderCompleted()
        {
            return View();
        }
        
        public ShoppingCart? GetShoppingCartByShopId(List<ShoppingCart> listCart,int shopId)
        {
            foreach (var item in listCart)
            {
                if (item.shopId == shopId)
                {
                    return item;
                }
            }
            return null;
        }
        public IActionResult RemoveFromCart(int productId, int shopId)
        {
            var listCart = HttpContext.Session.GetObjectFromJson<List<ShoppingCart>>("Cart");
            var cart= GetShoppingCartByShopId(listCart, shopId);
            if (cart is not null)
            {
                cart.RemoveItem(productId);// Lưu lại giỏ hàng vào Session sau khi đã xóa mục
                HttpContext.Session.SetObjectAsJson("Cart", listCart);
            }
            return RedirectToAction("Index");
        }
        
        public ActionResult UpdateCart(int id, int quantity, int shopId)
        {
            var listCart = HttpContext.Session.GetObjectFromJson<List<ShoppingCart>>("Cart") ?? new List<ShoppingCart>();
            var cart = GetShoppingCartByShopId(listCart, shopId);
            var findCartItem = cart.Items.FirstOrDefault(i => i.ProductId == id);
            if (findCartItem != null)
            {
                findCartItem.Quantity = (uint)quantity;
                HttpContext.Session.SetObjectAsJson("Cart", listCart);
            }
            return RedirectToAction("Index");
        }
        
        //tìm kiếm thông tin sản phẩm từ DB
        private async Task<Product> GetProductFromDatabase(int productId)
        {
            var product= await _context.Products.Include(p =>p.Shop).FirstOrDefaultAsync(p => p.ProductId == productId);
            return product;
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
        /*public ActionResult UCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            var findCartItem = cart.Items.FirstOrDefault(i => i.ProductId == id);
            if (findCartItem != null)
            {
                findCartItem.Quantity = (uint)quantity;
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return Json(findCartItem.Quantity * findCartItem.Price);
        }*/
    }
}
