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
        private readonly AndreyTestContext _context;
        public SmsController(AndreyTestContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public TwiMLResult Index(SmsRequest userRequest)
        {
            var response = new MessagingResponse();
            // Getting all the numbers in the system into an array and the number from the request.
            var userNumber = _context.Users.Select(x => x.PhoneNumber).ToArray();
            var requestNumber = (userRequest.From).ToString().Split("+1")[1];

            var userCat = _context.UserCategories
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .FirstOrDefault(x => x.Category.Name == userRequest.Body && x.ApplicationUser.PhoneNumber == requestNumber);

            var budgetedAmount = _context.UserCategories.Where(x => x.Category.Name == userRequest.Body).Sum(x => x.BudgetedAmount);
            var actualAmount = _context.Transaction.Where(x => x.Category.Name == userRequest.Body).Sum(y => y.Amount);

            if (userCat != null)
            {
                response.Message("Your remaining budgeted amount for " + userCat.Category.Name + " is " + (budgetedAmount - actualAmount) + ".");
                // response.Message("Your budgeted amount for " + userCat.Category.Name + " is " + userCat.BudgetedAmount.ToString("c"));
            }
            else
            {
                response.Message("Sorry, you got the wrong number.");
            }

            return TwiML(response);
          
        }
    }
}