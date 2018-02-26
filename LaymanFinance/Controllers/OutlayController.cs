﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using LaymanFinance.Models;
using System.Data.SqlClient;

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
            var outlay = _context.Outlay.Find(id);
            return View(outlay);
        }
    }
}