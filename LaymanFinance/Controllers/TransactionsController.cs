using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaymanFinance.Models;
using System.Security.Claims;

namespace LaymanFinance.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly LaymanFinanceContext _context;

        public TransactionsController(LaymanFinanceContext context)
        {
            _context = context;
        }

        // GET: List all of the Transactions
        public async Task<IActionResult> Index(string sort, string category)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            TransactionViewModel transactions = new TransactionViewModel
            {
                Transactions = (await _context.Users.Include(x => x.Transaction).ThenInclude(x => x.Category).FirstAsync(x => x.Id == userId)).Transaction,
                Categories = string.Join(",", _context.Category.Select(x => x.Name)).Split(",").Select(x => x.Trim()).Distinct().ToArray()
            };

            // Sorting by header functionality
            if (string.IsNullOrEmpty(sort))
            {
                transactions.Transactions = transactions.Transactions.OrderByDescending(x => x.DateOccurred).ToArray();
            }
            if (!string.IsNullOrEmpty(sort))
            {
                if (sort == "amount")
                {
                    transactions.Transactions = transactions.Transactions.OrderBy(x => x.Amount).ToArray();
                }
                if (sort == "source")
                {
                    transactions.Transactions = transactions.Transactions.OrderBy(x => x.Source).ToArray();
                }
            }

            // Filter functionality
            if (!string.IsNullOrEmpty(category))
            {
                transactions.Transactions = (await _context.Users
                    .Include(x => x.Transaction)
                    .ThenInclude(x => x.Category)
                    .FirstAsync(x => x.Id == userId))
                    .Transaction
                    .Where(x => x.Category.Name == category)
                    .ToList();
            }

            return View(transactions);
        }

        // GET: Transactions/Outlays
        public async Task<IActionResult> Outlays(string sort)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            TransactionViewModel outlays = new TransactionViewModel
            {
                Transactions = (await _context.Users.Include(x => x.Transaction).ThenInclude(x => x.Category).FirstAsync(x => x.Id == userId)).Transaction.Where(x => x.IsOutlay).ToList(),
                Categories = string.Join(",", _context.Category.Where(x => x.ForOutlays).Select(x => x.Name)).Split(",").Select(x => x.Trim()).Distinct().ToArray()
            };

            if (string.IsNullOrEmpty(sort))
            {
                outlays.Transactions = outlays.Transactions.OrderByDescending(x => x.DateOccurred).ToArray();
            }
            if (!string.IsNullOrEmpty(sort))
            {
                if (sort == "source")
                {
                    outlays.Transactions = outlays.Transactions.OrderBy(x => x.Source).ToArray();
                }
                if (sort == "amount")
                {
                    outlays.Transactions = outlays.Transactions.OrderBy(x => x.Amount).ToArray();
                }
            }
            return View(outlays);
        }

        // GET: Transactions/Inflows
        public async Task<IActionResult> Inflows(string sort)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            TransactionViewModel inflows = new TransactionViewModel
            {
                Transactions = (await _context.Users.Include(x => x.Transaction).ThenInclude(x => x.Category).FirstAsync(x => x.Id == userId)).Transaction.Where(x => x.IsInflow).ToList(),
                Categories = string.Join(",", _context.Category.Where(x => x.ForInflows).Select(x => x.Name)).Split(",").Select(x => x.Trim()).Distinct().ToArray()
            };

            if (string.IsNullOrEmpty(sort))
            {
                inflows.Transactions = inflows.Transactions.OrderByDescending(x => x.DateOccurred).ToArray();
            }
            if (!string.IsNullOrEmpty(sort))
            {
                if (sort == "source")
                {
                    inflows.Transactions = inflows.Transactions.OrderBy(x => x.Source).ToArray();
                }
                if (sort == "amount")
                {
                    inflows.Transactions = inflows.Transactions.OrderBy(x => x.Amount).ToArray();
                }
            }
            return View(inflows);
        }

        // GET: Transactions/EnterInflow
        public IActionResult EnterInflow()
        {
            TransactionEntryViewModel transactionEntryViewModel = new TransactionEntryViewModel
            {
                InflowCategories = _context.Category.Where(x => x.ForInflows).Select(x => x.Name).ToArray(),
            };
            return View(transactionEntryViewModel);
        }

        // GET: Transactions/EnterOutlay
        public IActionResult EnterOutlay()
        {
            TransactionEntryViewModel transactionEntryViewModel = new TransactionEntryViewModel
            {
                OutlayCategories = _context.Category.Where(x => x.ForOutlays).Select(x => x.Name).ToArray(),
            };
            return View(transactionEntryViewModel);
        }

        // POST: Transactions/EnterInflow
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnterInflow(TransactionEntryViewModel model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var transaction = model.Transaction;
            transaction.ApplicationUser = await _context.Users.FindAsync(userId);
            transaction.Category = await _context.Category.FirstAsync(x => x.Name == model.SelectedCategory);
            transaction.IsInflow = true;
            _context.Transaction.Add(transaction);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // POST: Transactions/EnterOutlay
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnterOutlay(TransactionEntryViewModel model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var transaction = model.Transaction;
            transaction.ApplicationUser = await _context.Users.FindAsync(userId);
            transaction.Category = await _context.Category.FirstAsync(x => x.Name == model.SelectedCategory);
            transaction.IsOutlay = true;
            await _context.Transaction.AddAsync(transaction);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction.SingleOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", transaction.UserId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", transaction.Category);
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,UserId,DateOccurred,DateEntered,DateModified,Amount,Source,Memo,IsInflow,IsOutlay")] Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.Id))
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
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", transaction.UserId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", transaction.CategoryId);
            return View(transaction);
        }









        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                //.Include(t => t.ApplicationUser)
                //.Include(t => t.Category)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaction = await _context.Transaction.SingleOrDefaultAsync(m => m.Id == id);
            _context.Transaction.Remove(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return _context.Transaction.Any(e => e.Id == id);
        }
    }
}
