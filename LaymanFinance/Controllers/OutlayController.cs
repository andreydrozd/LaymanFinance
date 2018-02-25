using System;
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
        public IActionResult Index()
        {
            OutlayModel model = new Models.OutlayModel
            {
                Date = DateTime.Now,
                Amount = 20,
                Payee = "Panda Express",
                Memo = "Saturday is for the boys.",
                Category = new Models.CategoryModel { ID = 1, Name = "Food" }
            };
            return View(model);
        }
    }
}