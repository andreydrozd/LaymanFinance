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

        public IActionResult Index(int id)
        {
            //TODO - Change so that it returns an array of outlays instead of a single one.
            var outlays = _context.Outlay.Include(x => x.Category).Single(x => x.Id == id);
            return View(outlays);
        }
    }
}