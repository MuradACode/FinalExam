using DAL.Data;
using DAL.Models;
using Exam.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.BottomAchivements = await _context.BottomAchivements.Where(n => !n.IsDeleted).ToListAsync();
            homeVM.TopAchivements = await _context.TopAchivements.Where(n => !n.IsDeleted).ToListAsync();
            homeVM.Contacts = await _context.Contacts.Where(n => !n.IsDeleted).ToListAsync();
            homeVM.ContactAddresses = await _context.ContactAddresses.Where(n => !n.IsDeleted).ToListAsync();
            homeVM.Features = await _context.Features.Where(n => !n.IsDeleted).ToListAsync();
            homeVM.Hero = await _context.Hero.Where(n => !n.IsDeleted).ToListAsync();

            return View(homeVM);
        }
    }
}
