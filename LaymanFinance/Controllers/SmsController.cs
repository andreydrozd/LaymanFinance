using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.AspNet.Common;
using Twilio.AspNet.Core;
using Twilio.TwiML;
using LaymanFinance.Models;
using System.Security.Claims;

namespace LaymanFinance.Controllers
{
    public class SmsController : TwilioController
    {
        private readonly LaymanFinanceContext _context;
        public SmsController(LaymanFinanceContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public TwiMLResult Index(SmsRequest userRequest)
        {
            var response = new MessagingResponse();

            DateTime currentDate = DateTime.Today;
            var currentMonth = currentDate.Month.ToString();
            var requestNumber = (userRequest.From).ToString().Split("+1")[1];

            var userCategory = _context.UserCategories
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .FirstOrDefault(x => x.Category.Name == userRequest.Body && x.ApplicationUser.PhoneNumber == requestNumber);

            var budgetedAmount = _context.UserCategories.Where(x => x.Category.Name == userRequest.Body).Sum(y => y.BudgetedAmount);
            var actualAmount = _context.Transaction.Where(x => x.Category.Name == userRequest.Body && x.DateOccurred.Month.ToString() == currentMonth).Sum(y => y.Amount);
            var remainingAmount = budgetedAmount - actualAmount;

            if (userCategory != null)
            {
                response.Message("You have " +remainingAmount.ToString("c")+ " budgeted amount for " + userCategory.Category.Name + " is.");
            }
            else
            {
                response.Message("Sorry, you got the wrong number.");
            }

            return TwiML(response);
          
        }
    }
}