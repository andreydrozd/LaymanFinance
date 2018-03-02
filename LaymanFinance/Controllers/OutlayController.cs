using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using LaymanFinance.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LaymanFinance.Controllers
{
    public class OutlayController : Controller
    {
        private AndreyTestContext _context;
        public OutlayController(AndreyTestContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var outlays = _context.Outlay.Include(x => x.Category);
            return View(outlays);
        }

        public IActionResult EnterOutlay(OutlayEntryViewModel)
        {
            return View(OutlayEntryViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnterOutlay()
        {
            var outlayEntryViewModel = _context.Select(x => new OutlayEntryViewModel
            {
                
            });

            return(outlayEntryViewModel);
        }
    }
}