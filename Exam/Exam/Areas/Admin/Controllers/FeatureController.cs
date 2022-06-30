using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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

            await _context.Features.AddAsync(feature);
            await _context.SaveChangesAsync();

            return RedirectToAction(controllerName: nameof(Feature), actionName: nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var feature = await _context.Features.Where(n => n.Id == id && !n.IsDeleted).FirstOrDefaultAsync();

            if (feature is null)
            {
                return NotFound();
            }

            return View(feature);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id,
                                              string featureIcon,
                                              string featureTitle,
                                              string featureDesc1,
                                              string featureDesc2)
        {
            var feature = await _context.Features.Where(n => n.Id == id && !n.IsDeleted).FirstOrDefaultAsync();

            if (feature is null)
            {
                return NotFound();
            }

            if (featureTitle is null || featureIcon is null || featureDesc1 is null || featureDesc2 is null)
            {
                ModelState.AddModelError("", "All fields are required");
                return View(feature);
            }

            feature.Icon = featureIcon;
            feature.Title = featureTitle;
            feature.Desc1 = featureDesc1;
            feature.Desc2 = featureDesc2;

            _context.Features.Update(feature);
            await _context.SaveChangesAsync();

            return RedirectToAction(controllerName: nameof(Feature), actionName: nameof(Details), routeValues: new { id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var feature = await _context.Features.Where(n => n.Id == id && !n.IsDeleted).FirstOrDefaultAsync();

            if (feature is null)
            {
                return NotFound();
            }

            return View(feature);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Feature feature)
        {
            var dbFeature = await _context.Features.Where(n => !n.IsDeleted).FirstOrDefaultAsync();

            if (dbFeature is null)
            {
                return NotFound();
            }

            if (feature.Title is null)
            {
                ModelState.AddModelError("", "Field is empty");
                return View(dbFeature);
            }

            if (feature.Title.Trim() != dbFeature.Title)
            {
                ModelState.AddModelError("", "Titles don't match");
                return View(dbFeature);
            }

            dbFeature.IsDeleted = true;

            _context.Features.Update(dbFeature);
            await _context.SaveChangesAsync();

            return RedirectToAction(controllerName: nameof(Feature), actionName: nameof(Index));
        }
    }
}
