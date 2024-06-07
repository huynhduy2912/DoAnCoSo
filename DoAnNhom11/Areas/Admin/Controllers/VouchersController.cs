using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;

namespace DoAnNhom11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VouchersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VouchersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Vouchers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Vouchers.Where(v=>v.ShopId==-1).Include(v => v.VoucherCategory);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Vouchers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucher = await _context.Vouchers
                .Include(v => v.VoucherCategory)
                .FirstOrDefaultAsync(m => m.VoucherId == id);
            if (voucher == null||voucher.ShopId!=-1)
            {
                return NotFound();
            }

            return View(voucher);
        }

        // GET: Admin/Vouchers/Create
        public IActionResult Create()
        {
            ViewData["ShopId"] = new SelectList(_context.Shops, "ShopId", "ShopId");
            ViewData["VoucherCategoryId"] = new SelectList(_context.VoucherCategory, "VoucherCategoryId", "TenLoai");
            return View();
        }

        // POST: Admin/Vouchers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VoucherId,VoucherCode,PhanTramGiam,GiamToiDa,DonToiThieu,NgayHetHan,NgayBatDau,SoLuongCon,VoucherCategoryId")] Voucher voucher)
        {
            if (ModelState.IsValid)
            {
                if (voucher.DonToiThieu == null)
                {
                    voucher.DonToiThieu = -1;
                }
                if (voucher.GiamToiDa == null)
                {
                    voucher.GiamToiDa = -1;
                }
                voucher.ShopId = -1;
                _context.Add(voucher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VoucherCategoryId"] = new SelectList(_context.VoucherCategory, "VoucherCategoryId", "TenLoai", voucher.VoucherCategoryId);
            return View(voucher);
        }

        // GET: Admin/Vouchers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucher = await _context.Vouchers.FindAsync(id);
            if (voucher == null || voucher.ShopId != -1)
            {
                return NotFound();
            }
            ViewData["VoucherCategoryId"] = new SelectList(_context.VoucherCategory, "VoucherCategoryId", "TenLoai", voucher.VoucherCategoryId);
            return View(voucher);
        }

        // POST: Admin/Vouchers/Edit/5
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
                    if (voucher.DonToiThieu == null)
                    {
                        voucher.DonToiThieu = -1;
                    }
                    if (voucher.GiamToiDa == null)
                    {
                        voucher.GiamToiDa = -1;
                    }
                    voucher.ShopId = -1;
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

        // GET: Admin/Vouchers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucher = await _context.Vouchers
                .Include(v => v.VoucherCategory)
                .FirstOrDefaultAsync(m => m.VoucherId == id);
            if (voucher == null || voucher.ShopId != -1)
            {
                return NotFound();
            }

            return View(voucher);
        }

        // POST: Admin/Vouchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voucher = await _context.Vouchers.FindAsync(id);
            if (voucher != null)
            {
               voucher.NgayHetHan=DateTime.Now;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoucherExists(int id)
        {
            return _context.Vouchers.Any(e => e.VoucherId == id);
        }
    }
}
