using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaymanFinance.Models;
using System.Security.Claims;

namespace LaymanFinance.Controllers
{
    public class LedgerController : Controller
    {
        private AndreyTestContext _context;
        public LedgerController (AndreyTestContext context)
        {
            _context = context;
        }

        // GET: Ledger
        public ActionResult Index()
        {
            LedgerViewModel ledger = new LedgerViewModel();
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ledger.Outlay = _context.Users.Include(x => x.Outlay).First(x => x.Id == userId).Outlay.ToArray();
            ledger.Inflow = _context.Users.Include(x => x.Inflow).First(x => x.Id == userId).Inflow.ToArray();
            return View(ledger);
        }
    }
}