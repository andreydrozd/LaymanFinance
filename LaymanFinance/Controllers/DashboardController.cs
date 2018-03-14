using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaymanFinance.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace LaymanFinance.Controllers
{
    public class DashboardController : Controller
    {
        private AndreyTestContext _context;
        public DashboardController(AndreyTestContext context)
        {
            _context = context;
        }

        // GET: Transactions returned based on time period selected. Returns 5 at a time.
        public async Task<IActionResult> Index(int? month, int? year, int count = 5)
        {
            month = month ?? DateTime.Now.Month;
            year = year ?? DateTime.Now.Year;
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            DateTime startPeriod = new DateTime(year.Value, month.Value, 1);
            DateTime endPeriod = startPeriod.AddMonths(1);
            TransactionViewModel model = new TransactionViewModel
            {
                Transactions = (await _context.Users
                    .Include(x => x.Transaction)
                    .ThenInclude(x => x.Category)
                    .FirstAsync(x => x.Id == userId))
                    .Transaction.Where(x => x.DateOccurred > startPeriod && x.DateOccurred < endPeriod)
                    .OrderByDescending(x => x.DateOccurred)
                    .Take(count).ToList(),

                Categories = string.Join(",", _context.Category.Select(x => x.Name)).Split(",").Select(x => x.Trim()).Distinct().ToArray(),
            };

            return View(model);
        }
    }
}