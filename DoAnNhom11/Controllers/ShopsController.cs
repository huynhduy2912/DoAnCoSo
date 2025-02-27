﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnNhom11.Models;
using static NuGet.Packaging.PackagingConstants;
using Azure;
using X.PagedList;

namespace DoAnNhom11.Controllers
{
    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Details(int? ma)
        {
         
            if (ma == null)
            {
                return NotFound();
            }
            var shop = await _context.Shops
                .Include(s => s.ShopCategories)
                .FirstOrDefaultAsync(m => m.ShopId == ma);
            if (shop == null||shop.BiChan==true)
            {
                return NotFound();
            }
            
            var listProductByShop = await _context.Products
               .Where(p => p.ShopId == ma).Where(p => p.DaAn == false).AsNoTracking().ToListAsync();

            int totalQuantitySold = 0;
            foreach (var product in listProductByShop)
            {
                totalQuantitySold += _context.OrderDetails.Where(o => o.ProductId == product.ProductId).Sum(o => o.Quantity);
            }
            var _listProductByShopShow = listProductByShop.Where(p => p.DaAn == false&&p.SoLuongCon!=0).Where(p => p.DaAn == false).Reverse();

           

            ViewBag.TotalQuantitySold = totalQuantitySold;
            ViewBag.ProductQuantity = listProductByShop.Count();
            return View(shop);
        }

        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ShopId == id);
        }
    }
}
