using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaymanFinance.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace LaymanFinance.Controllers
{
    public class DashboardController : Controller
    {
        private LaymanFinanceContext _context;
        public DashboardController(LaymanFinanceContext context)
        {
            _context = context;
        }

        // GET: Transactions returned based on time period selected. Returns number is HC at the "count" variable.
        public async Task<IActionResult> Index(int? month, int? year, int count = 5)
        {
            month = month ?? DateTime.Now.Month;
            year = year ?? DateTime.Now.Year;
            ViewData["Year"] = year.ToString();
            ViewData["Month"] = new DateTime(year.Value, month.Value, 1).ToString("MMM");

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            // Date filters for the list of transactions and charts
            DateTime startPeriod = new DateTime(year.Value, month.Value, 1);
            DateTime endPeriod = startPeriod.AddMonths(1).AddDays(-1);

            // Date filters for the graph
            DateTime graphStartPeriod = startPeriod.AddMonths(-6);
            DateTime graphEndPeriod = startPeriod.AddMonths(1).AddDays(-1);

            var userTransactions = await _context.Users
                    .Include(x => x.Transaction)
                    .ThenInclude(x => x.Category)
                    .FirstAsync(x => x.Id == userId);

            var userCategories = (await _context.Users
                    .Include(x => x.UserCategories)
                    .ThenInclude(x => x.Category)
                    .FirstAsync(x => x.Id == userId)).UserCategories;

            TransactionViewModel model = new TransactionViewModel
            {
                Transactions = userTransactions
                    .Transaction.Where(x => x.DateOccurred > startPeriod && x.DateOccurred < endPeriod)
                    .OrderByDescending(x => x.DateOccurred)
                    .Take(count).ToList(),
                AcutalOutlays = userTransactions
                    .Transaction.Where(x => x.DateOccurred > startPeriod && x.DateOccurred < endPeriod && x.IsOutlay)
                    .Sum(x => x.Amount),
                BudgetOutlays = userCategories
                    .Where(x => x.Category.ForOutlays)
                    .Sum(x => x.BudgetedAmount),
                OutlayTotals = JsonConvert.SerializeObject(userTransactions
                                .Transaction.Where(x => x.IsOutlay && (x.DateOccurred > startPeriod) && (x.DateOccurred < endPeriod))
                                .OrderBy(x => x.Category.Name)
                                .GroupBy(x => x.Category.Name)
                                .Select(x => new { Category = x.Key, Amount = x.Sum(y => y.Amount) })),
                OutlayTotalsBudget = JsonConvert.SerializeObject(userCategories
                                        .Where(x => x.Category.ForOutlays)
                                        .OrderBy(x=> x.Category.Name)
                                        .GroupBy(x => x.Category.Name)
                                        .Select(x => new { Category = x.Key, Amount = x.Sum(y => y.BudgetedAmount) })),
                TransactionTotals = JsonConvert.SerializeObject(userTransactions
                                    .Transaction.Where(x => x.DateOccurred > graphStartPeriod && x.DateOccurred < graphEndPeriod)
                                    .GroupBy(x => x.DateOccurred.Month)
                                    .Select(x => new { Month = x.Key, Amount = x.Sum(y => y.Amount) }))
            };
            return View(model);
        }
    }
}