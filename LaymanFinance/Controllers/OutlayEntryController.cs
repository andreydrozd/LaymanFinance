using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaymanFinance.Models;

namespace LaymanFinance.Controllers
{
    public class OutlayEntryController : Controller
    {
        // Don't need a decorator for GET requests. Method defaults to GET.
        public IActionResult Index()
        {
            // Create an array to pass into the form based off the model.
            OutlayEntryModel m = new OutlayEntryModel
            {
                Categories = new CategoryModel[] {
                    new CategoryModel
                    {
                         ID = 1, Name = "Food"
                    },
                    new CategoryModel
                    {
                         ID = 2, Name = "Car"
                    },
                    new CategoryModel
                    {
                         ID = 3, Name = "House"
                    }
                }
            };
            return View(m);
        }

        //Pass in data according to the model. Name of the inputs have to match model properties.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(OutlayEntryModel model)
        {
            // Server-side validation
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            model.Categories = new CategoryModel[] {
                new CategoryModel
                {
                    ID = 1, Name = "Food"
                },
                new CategoryModel
                {
                    ID = 2, Name = "Car"
                },
                new CategoryModel
                {
                    ID = 3, Name = "House"
                }
            };

            // Otherwise, redisplay the page.
            return View(model);
        }

    }
}