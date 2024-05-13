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
    public class ReviewsImagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewsImagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ReviewsImages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReviewsImage.ToListAsync());
        }

        // GET: Admin/ReviewsImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewsImage = await _context.ReviewsImage
                .FirstOrDefaultAsync(m => m.ReviewsImageId == id);
            if (reviewsImage == null)
            {
                return NotFound();
            }

            return View(reviewsImage);
        }

        // GET: Admin/ReviewsImages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ReviewsImages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewsImageId,Url,ReviewsId")] ReviewsImage reviewsImage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reviewsImage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reviewsImage);
        }

        // GET: Admin/ReviewsImages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewsImage = await _context.ReviewsImage.FindAsync(id);
            if (reviewsImage == null)
            {
                return NotFound();
            }
            return View(reviewsImage);
        }

        // POST: Admin/ReviewsImages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewsImageId,Url,ReviewsId")] ReviewsImage reviewsImage)
        {
            if (id != reviewsImage.ReviewsImageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reviewsImage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewsImageExists(reviewsImage.ReviewsImageId))
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
            return View(reviewsImage);
        }

        // GET: Admin/ReviewsImages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reviewsImage = await _context.ReviewsImage
                .FirstOrDefaultAsync(m => m.ReviewsImageId == id);
            if (reviewsImage == null)
            {
                return NotFound();
            }

            return View(reviewsImage);
        }

        // POST: Admin/ReviewsImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reviewsImage = await _context.ReviewsImage.FindAsync(id);
            if (reviewsImage != null)
            {
                _context.ReviewsImage.Remove(reviewsImage);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewsImageExists(int id)
        {
            return _context.ReviewsImage.Any(e => e.ReviewsImageId == id);
        }
    }
}
