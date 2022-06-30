using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Areas.Admin.Views.Dashboard
{
    [Area("Admin")]
    public class FeatureController : Controller
    {
        private readonly AppDbContext _context;

        public FeatureController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var features = await _context.Features.Where(n => !n.IsDeleted).ToListAsync();

            if (features is null)
            {
                return NotFound();
            }

            return View(features);
        }

        public async Task<IActionResult> Details(int id)
        {
            var feature = await _context.Features.Where(n => n.Id == id && !n.IsDeleted).FirstOrDefaultAsync();

            if (feature is null)
            {
                return NotFound();
            }

            return View(feature);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Feature feature)
        {
            if (feature.Title is null || feature.Icon is null || feature.Desc1 is null || feature.Desc2 is null)
            {
                ModelState.AddModelError("", "All fields are required");
                return View();
            }

            feature.CreatedDate = DateTime.Now;

            await _context.AddAsync(feature);
            await _context.SaveChangesAsync();

            return RedirectToAction(controllerName: nameof(Feature), actionName: nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var feature = await _context.Features.Where(n => n.Id == id && !n.IsDeleted).FirstOrDefaultAsync();

            if (feature is null)
            {
                return NotFound();
            }

            return View(feature);
        }

        // POST: FeatureController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FeatureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FeatureController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
