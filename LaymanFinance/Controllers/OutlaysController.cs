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
        public async Task<IActionResult> Index(string sort = "")
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var outlays = (await _context.Users.Include(x => x.Outlay).ThenInclude(x => x.Category).FirstAsync(x => x.Id == userId)).Outlay;
            if (!string.IsNullOrEmpty(sort))
            {
                if(sort == "payee")
                {
                    outlays = outlays.OrderBy(x => x.Payee).ToArray();
                }
                if(sort == "amount")
                {
                    outlays = outlays.OrderBy(x => x.Amount).ToArray();
                }
            }
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
        public async Task<IActionResult> EnterOutlay(OutlayEntryViewModel model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var outlay = model.Outlay;
            outlay.ApplicationUser = await _context.Users.FindAsync(userId);
            outlay.Category = await _context.Category.FirstAsync(x => x.Name == model.SelectedCategory);
            _context.Outlay.Add(outlay);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}