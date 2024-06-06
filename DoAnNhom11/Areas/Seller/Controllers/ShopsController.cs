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
    [Authorize(Roles = "Developer,ShopOwner")]

    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private ApplicationUser? seller;
        public ShopsController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> BlockDetail()
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
            if (shop == null||shop.BiChan==false)
            {
                return NotFound();
            }
            return View();
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
        public async Task<IActionResult> Edit(Shop shop, IFormFile imageAvatar, IFormFile imageBackground,string specificAddress)
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
                shop.DiaChi = specificAddress+", " + shop.DiaChi;
                _context.Update(shop);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", "Shops");
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
            var role = await _roleManager.FindByNameAsync("ShopStaff");
            var userIds = await _context.UserRoles
                                    .Where(ur => ur.RoleId == role.Id)
                                    .Select(ur => ur.UserId)
                                    .ToListAsync();
            var staffInShop = await _context.Users
                                   .Where(u => userIds.Contains(u.Id)&&u.ShopId==seller.ShopId)
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
        
        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(RegisterViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                if (seller == null)
                {
                    seller = await _userManager.GetUserAsync(User);
                }
                var user = new ApplicationUser
                {

                    UserName = model.UserName,
                    Email = model.Email,
                    FullName = model.FullName,
                    Address = model.Address,
                    Avatar = model.Avatar,
                    ShopId = seller.ShopId,
                    
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync("ShopStaff"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("ShopStaff"));
                    }

                    await _userManager.AddToRoleAsync(user, "ShopStaff");

                    return RedirectToAction("Staffs", "Shops");
                }
                else
                {
                    Content("Đăng Ký Không Thành Công");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetStaffPassword(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest("User ID is required.");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("User not found.");
            }
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, "P@55W0rd");

            if (result.Succeeded)
            {

                return RedirectToAction("Staffs", "Shops");
            }

            return BadRequest(result.Errors);
        }
        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ShopId == id);
        }

        /*[HttpPost]
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
        }*/
    }
}
