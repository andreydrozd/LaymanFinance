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

            var userNumber = _context.Users.Select(x => x.PhoneNumber).ToArray();
            var requestNumber = (userRequest.From).ToString().Split("+1")[1];
            // response.Message($"Hello, {userRequest.From}!");
            System.Diagnostics.Debug.Write("Hi !");
            var userCat = _context.UserCategories.Include(x => x.Category).Include(x => x.ApplicationUser).FirstOrDefault(x => x.Category.Name == userRequest.Body && x.ApplicationUser.PhoneNumber == requestNumber);
            if (userCat != null)
            {
                
                response.Message("Your budgeted amount for " + userCat.Category.Name + " is " + userCat.Category.BudgetedAmount.ToString("c"));
            }
            else
            {
                response.Message("Sorry, you got the wrong number.");
            }

            return TwiML(response);
          
        }
    }
}