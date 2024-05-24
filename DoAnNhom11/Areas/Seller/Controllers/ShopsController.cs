using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;
using DoAnNhom11.Extensions;
using Microsoft.CodeAnalysis;
using Azure;
using X.PagedList;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Build.Evaluation;

namespace DoAnNhom11.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize]
    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationUser? seller;
        public ShopsController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> Edit()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int id = seller.ShopId ?? 0;
            if (id == 0)
            {
                return NotFound();
            }

            var shop = await _context.Shops.FindAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            ViewData["ShopCategoryId"] = new SelectList(_context.ShopCategories, "ShopCategoryId", "TenLoai", shop.ShopCategoryId);
            return View(shop);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Shop shop, IFormFile imageAvatar, IFormFile imageBackground)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int id = seller.ShopId ?? 0;
            if (id == 0)
            {
                return NotFound();
            }
            if (id != shop.ShopId)
            {
                return NotFound();
            }
            try
            {
                if (imageAvatar != null)
                {
                    shop.AnhDaiDien = await UploadImage.SaveImage(imageAvatar);
                }

                if (imageBackground != null)
                {
                    shop.AnhBia = await UploadImage.SaveImage(imageBackground);
                }

                _context.Update(shop);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopExists(shop.ShopId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            ViewData["ShopCategoryId"] = new SelectList(_context.ShopCategories, "ShopCategoryId", "ShopCategoryId", shop.ShopCategoryId);
            return View(shop);

        }
        public async Task<IActionResult> Staffs()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int id = seller.ShopId ?? 0;
            if (id == 0)
            {
                return NotFound();
            }
            var staffInShop = await _context.Users
             .Where(u => u.ShopId == id)
             .ToListAsync();

            return View(staffInShop);
        }

        [HttpPost]
        public async Task<IActionResult> Staffs(string userName)
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int id = seller.ShopId ?? 0;
            if (id == 0)
            {
                return NotFound();
            }

            var staffInShop = await _context.Users
             .Where(u => u.ShopId == id)
             .ToListAsync();

            if (string.IsNullOrEmpty(userName))
            {
                ViewBag.Message = -1;
                return View(staffInShop);

            }         
            var staff = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
            if(staff == null)
            {
                ViewBag.Message = 0;
                return View(staffInShop);
            }
            if (staff.ShopId == seller.ShopId)
            {
                ViewBag.Message = 2;
                return View(staffInShop);
            }
            else if(staff.ShopId != null)
            {
                ViewBag.Message = -2;
                return View(staffInShop);
            }


            
            staff.ShopId = id;
            await _context.SaveChangesAsync();
            ViewBag.Message = 1;
            staffInShop = await _context.Users
             .Where(u => u.ShopId == id)
             .ToListAsync();
            return View(staffInShop);
        }
        public async Task<IActionResult> GetShopName()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            int id = seller.ShopId ?? 0;
            if (id == 0)
            {
                return NotFound();
            }

            var shop = await _context.Shops.FindAsync(id);
            ViewBag.Shop = shop;

            return PartialView("/Areas/Seller/Views/Shared/_ShopNamePartial.cshtml");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteStaff(string userName)
        {                
            var staff = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);  
            if(staff == null)
            {
                return NotFound();
            }
            staff.ShopId = null;
            await _context.SaveChangesAsync();           
            return RedirectToAction("Staffs","Shops");
        }
        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ShopId == id);
        }
    }
}
