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
    public class InflowsController : Controller
    {
        private AndreyTestContext _context;
        public InflowsController(AndreyTestContext context)
        {
            _context = context;
        }

        // GET: Inflows
        public IActionResult Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var inflows = _context.Users.Include(x => x.Inflow).ThenInclude(x => x.Category).First(x => x.Id == userId).Inflow;
            return View(inflows);
        }

        // GET: Inflows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inflow = await _context.Inflow
                .Include(i => i.Category)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (inflow == null)
            {
                return NotFound();
            }

            return View(inflow);
        }

        // GET: Inflows/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id");
            return View();
        }

        // POST: Inflows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,DateOccurred,DateEntered,DateModified,Amount,Payor,Memo")] Inflow inflow)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inflow);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", inflow.CategoryId);
            return View(inflow);
        }

        // GET: Inflows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inflow = await _context.Inflow.SingleOrDefaultAsync(m => m.Id == id);
            if (inflow == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", inflow.CategoryId);
            return View(inflow);
        }

        // POST: Inflows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,DateOccurred,DateEntered,DateModified,Amount,Payor,Memo")] Inflow inflow)
        {
            if (id != inflow.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inflow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InflowExists(inflow.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Id", inflow.CategoryId);
            return View(inflow);
        }

        // GET: Inflows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inflow = await _context.Inflow
                .Include(i => i.Category)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (inflow == null)
            {
                return NotFound();
            }

            return View(inflow);
        }

        // POST: Inflows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inflow = await _context.Inflow.SingleOrDefaultAsync(m => m.Id == id);
            _context.Inflow.Remove(inflow);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InflowExists(int id)
        {
            return _context.Inflow.Any(e => e.Id == id);
        }
    }
}
