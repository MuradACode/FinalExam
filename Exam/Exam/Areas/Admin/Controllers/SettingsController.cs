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
    public class SettingsController : Controller
    {
        private readonly AppDbContext _context;

        public SettingsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var settings = await _context.Settings.ToListAsync();

            if (settings is null)
            {
                return NotFound();
            }

            return View(settings);
        }

        public async Task<IActionResult> Details(int id)
        {
            var setting = await _context.Settings.Where(n => n.Id == id).FirstOrDefaultAsync();

            if (setting is null)
            {
                return NotFound();
            }

            return View(setting);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Settings setting)
        {
            if (setting.Key is null || setting.Value is null)
            {
                ModelState.AddModelError("", "All fields are required");
                return View();
            }

            await _context.Settings.AddAsync(setting);
            await _context.SaveChangesAsync();

            return RedirectToAction(controllerName: nameof(Settings), actionName: nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var setting = await _context.Settings.Where(n => n.Id == id).FirstOrDefaultAsync();

            if (setting is null)
            {
                return NotFound();
            }

            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id,
                                              string settingsKey,
                                              string settingsValue)
        {
            var setting = await _context.Settings.Where(n => n.Id == id).FirstOrDefaultAsync();

            if (setting is null)
            {
                return NotFound();
            }

            if (settingsKey is null || settingsValue is null)
            {
                ModelState.AddModelError("", "All fields are required");
                return View(setting);
            }

            setting.Key = settingsKey;
            setting.Value = settingsValue;

            _context.Settings.Update(setting);
            await _context.SaveChangesAsync();

            return RedirectToAction(controllerName: nameof(Settings), actionName: nameof(Details), routeValues: new { id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var setting = await _context.Settings.Where(n => n.Id == id).FirstOrDefaultAsync();

            if (setting is null)
            {
                return NotFound();
            }

            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Settings setting)
        {
            var dbSetting = await _context.Settings.FirstOrDefaultAsync();

            if (dbSetting is null)
            {
                return NotFound();
            }

            if (setting.Key is null)
            {
                ModelState.AddModelError("", "Field is empty");
                return View(dbSetting);
            }

            if (dbSetting.Key.Trim() != dbSetting.Key)
            {
                ModelState.AddModelError("", "Keys don't match");
                return View(dbSetting);
            }


            _context.Settings.Remove(dbSetting);
            await _context.SaveChangesAsync();

            return RedirectToAction(controllerName: nameof(Settings), actionName: nameof(Index));
        }
    }
}
