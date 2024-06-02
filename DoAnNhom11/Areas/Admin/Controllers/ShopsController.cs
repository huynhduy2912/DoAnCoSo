﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;
using Microsoft.AspNetCore.Identity;
using NuGet.Protocol.Plugins;
using Microsoft.AspNetCore.Authorization;

namespace DoAnNhom11.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Developer")]

    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public ShopsController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Admin/Shops
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Shops.Include(s => s.ShopCategories);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Shops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .Include(s => s.ShopCategories)
                .FirstOrDefaultAsync(m => m.ShopId == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        public IActionResult AddShopOwner()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddShopOwner(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var shop = new Shop
                {
                    TenCuaHang = " ",
                    DiaChi = " ",
                    LienHe = " ",
                    AnhDaiDien = " ",
                    AnhBia ="  ",
                    NgayTao = DateTime.Now,
                    MoTa = " ",
                    ShopCategoryId=1
                };

                _context.Shops.Add(shop);
                await _context.SaveChangesAsync();
                var user = new ApplicationUser
                {

                    UserName = model.UserName,
                    Email = model.Email,
                    FullName = model.FullName,
                    Address = model.Address,
                    Avatar = model.Avatar,
                    ShopId = shop.ShopId
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync("ShopOwner"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("ShopOwner"));
                    }

                    await _userManager.AddToRoleAsync(user, "ShopOwner");

                    return RedirectToAction("Index", "Shops");
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
        public async Task<IActionResult> ResetShopOwnerPassword(string userId)
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
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, "P@55W0rd");

            if (result.Succeeded)
            {
                return Ok("Mật khẩu reset thành công.");
            }

            return BadRequest(result.Errors);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .Include(s => s.ShopCategories)
                .FirstOrDefaultAsync(m => m.ShopId == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        // POST: Admin/Shops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shop = await _context.Shops.FindAsync(id);
            if (shop != null)
            {
                _context.Shops.Remove(shop);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ShopId == id);
        }
    }
}
