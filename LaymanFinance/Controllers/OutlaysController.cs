using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using LaymanFinance.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LaymanFinance.Controllers
{
    public class OutlaysController : Controller
    {
        private AndreyTestContext _context;
        public OutlaysController(AndreyTestContext context)
        {
            _context = context;
        }

        // GET: Outlays
        public IActionResult Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var outlays = _context.Users.Include(x => x.Outlay).ThenInclude(x => x.Category).First(x => x.Id == userId).Outlay;
            return View(outlays);
        }

        // GET: Outlays/EnterOutlay
        public IActionResult EnterOutlay()
        {
            OutlayEntryViewModel outlayEntryViewModel = new OutlayEntryViewModel();
            outlayEntryViewModel.Categories = _context.Category.Where(x => x.ForOutlays).Select(x => x.Name).ToArray();
            return View(outlayEntryViewModel);
        }

        // POST: Outlays/EnterOutlay
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnterOutlay(OutlayEntryViewModel model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var outlay = model.Outlay;
            outlay.ApplicationUser = _context.Users.Find(userId);
            outlay.Category = _context.Category.First(x => x.Name == model.SelectedCategory);
            _context.Outlay.Add(outlay);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}