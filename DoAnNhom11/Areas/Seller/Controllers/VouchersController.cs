using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace DoAnNhom11.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize(Roles = "Developer,ShopStaff,ShopOwner")]
    public class VouchersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationUser? seller;
        public VouchersController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }

        public async Task<IActionResult> Index()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = _context.Vouchers.Where(v=>v.ShopId==seller.ShopId).Include(v => v.VoucherCategory);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> VoucherExpired()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = _context.Vouchers.Where(v=>v.ShopId==seller.ShopId&&v.NgayHetHan<DateTime.Now).Include(v => v.VoucherCategory);
            return View("Index", await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> VoucherUnamount()
        {
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var applicationDbContext = _context.Vouchers.Where(v=>v.ShopId==seller.ShopId&&v.SoLuongCon<=0).Include(v => v.VoucherCategory);
            return View("Index", await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            var voucher = await _context.Vouchers
                .Include(v => v.VoucherCategory)
                .FirstOrDefaultAsync(m => m.VoucherId == id);
            if (voucher == null || voucher.ShopId!=seller.ShopId)
            {
                return NotFound();
            }

            return View(voucher);
        }

        // GET: Seller/Vouchers/Create
        public IActionResult Create()
        {
            ViewData["VoucherCategoryId"] = new SelectList(_context.VoucherCategory, "VoucherCategoryId", "TenLoai");
            return View();
        }

        // POST: Seller/Vouchers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VoucherId,VoucherCode,PhanTramGiam,GiamToiDa,DonToiThieu,NgayHetHan,NgayBatDau,SoLuongCon,VoucherCategoryId")] Voucher voucher)
        {
            if (ModelState.IsValid)
            {
                if (seller == null)
                {
                    seller = await _userManager.GetUserAsync(User);
                }
                if (voucher.DonToiThieu == null)
                {
                    voucher.DonToiThieu = -1;
                }
                if (voucher.GiamToiDa == null)
                {
                    voucher.GiamToiDa = -1;
                }
                voucher.ShopId = seller.ShopId??0;
                _context.Add(voucher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VoucherCategoryId"] = new SelectList(_context.VoucherCategory, "VoucherCategoryId", "TenLoai", voucher.VoucherCategoryId);
            return View(voucher);
        }

        // GET: Seller/Vouchers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var voucher = await _context.Vouchers.FindAsync(id);
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            if (voucher == null || voucher.ShopId != seller.ShopId)
            {
                return NotFound();
            }
            ViewData["VoucherCategoryId"] = new SelectList(_context.VoucherCategory, "VoucherCategoryId", "TenLoai", voucher.VoucherCategoryId);
            return View(voucher);
        }

        // POST: Seller/Vouchers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VoucherId,VoucherCode,PhanTramGiam,GiamToiDa,DonToiThieu,NgayHetHan,NgayBatDau,SoLuongCon,VoucherCategoryId")] Voucher voucher)
        {
            if (id != voucher.VoucherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (seller == null)
                    {
                        seller = await _userManager.GetUserAsync(User);
                    }
                    if (voucher.DonToiThieu == null)
                    {
                        voucher.DonToiThieu = -1;
                    }
                    if (voucher.GiamToiDa == null)
                    {
                        voucher.GiamToiDa = -1;
                    }
                    voucher.ShopId = seller.ShopId ?? 0;
                    _context.Update(voucher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoucherExists(voucher.VoucherId))
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
            ViewData["VoucherCategoryId"] = new SelectList(_context.VoucherCategory, "VoucherCategoryId", "TenLoai", voucher.VoucherCategoryId);
            return View(voucher);
        }

        /*// GET: Seller/Vouchers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucher = await _context.Vouchers
                .Include(v => v.VoucherCategory)
                .FirstOrDefaultAsync(m => m.VoucherId == id);
            if (seller == null)
            {
                seller = await _userManager.GetUserAsync(User);
            }
            if (voucher == null || voucher.ShopId != seller.ShopId)
            {
                return NotFound();
            }

            return View(voucher);
        }

        // POST: Seller/Vouchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voucher = await _context.Vouchers.FindAsync(id);
            if (voucher != null)
            {
                _context.Vouchers.Remove(voucher);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        private bool VoucherExists(int id)
        {
            return _context.Vouchers.Any(e => e.VoucherId == id);
        }
    }
}
