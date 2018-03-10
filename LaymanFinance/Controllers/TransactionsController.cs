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
        private readonly AndreyTestContext _context;

        public TransactionsController(AndreyTestContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index(string sort)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var transactions = (await _context.Users.Include(x => x.Transaction).ThenInclude(x => x.Category).FirstAsync(x => x.Id == userId)).Transaction;
            if (string.IsNullOrEmpty(sort))
            {
                transactions = transactions.OrderBy(x => x.DateOccurred).ToArray();
            }
            if (!string.IsNullOrEmpty(sort))
            {
                if(sort == "source")
                {
                    transactions = transactions.OrderBy(x => x.Source).ToArray();
                }
                if(sort == "amount")
                {
                    transactions = transactions.OrderBy(x => x.Amount).ToArray();
                }
            }
            return View(transactions);
        }

        // GET: Outlays
        public async Task<IActionResult> Outlays(string sort)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var outlays = (await _context.Users.Include(x => x.Transaction).ThenInclude(x => x.Category).FirstAsync(x => x.Id == userId)).Transaction.Where(x => x.IsOutlay);
            if (string.IsNullOrEmpty(sort))
            {
                outlays = outlays.OrderBy(x => x.DateOccurred).ToArray();
            }
            if (!string.IsNullOrEmpty(sort))
            {
                if (sort == "source")
                {
                    outlays = outlays.OrderBy(x => x.Source).ToArray();
                }
                if (sort == "amount")
                {
                    outlays = outlays.OrderBy(x => x.Amount).ToArray();
                }
            }
            return View(outlays);
        }

        // GET: Inflows
        public async Task<IActionResult> Inflows(string sort)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var inflows = (await _context.Users.Include(x => x.Transaction).ThenInclude(x => x.Category).FirstAsync(x => x.Id == userId)).Transaction.Where(x => x.IsInflow);
            if (string.IsNullOrEmpty(sort))
            {
                inflows = inflows.OrderBy(x => x.DateOccurred).ToArray();
            }
            if (!string.IsNullOrEmpty(sort))
            {
                if (sort == "source")
                {
                    inflows = inflows.OrderBy(x => x.Source).ToArray();
                }
                if (sort == "amount")
                {
                    inflows = inflows.OrderBy(x => x.Amount).ToArray();
                }
            }
            return View(inflows);
        }















        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.ApplicationUser)
                .Include(t => t.Category)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,UserId,DateOccurred,DateEntered,DateModified,Amount,Source,Memo,IsInflow,IsOutlay")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", transaction.UserId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", transaction.CategoryId);
            return View(transaction);
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", transaction.UserId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", transaction.CategoryId);
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", transaction.UserId);
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
                .Include(t => t.ApplicationUser)
                .Include(t => t.Category)
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
