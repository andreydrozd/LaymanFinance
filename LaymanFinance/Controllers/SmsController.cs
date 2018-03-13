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
        public TwiMLResult Index(SmsRequest userRequest)
        {
            var response = new MessagingResponse();

            var userNumber = _context.Users.Select(x => x.PhoneNumber).ToArray();
            string requestBody = Request.Form["Body"];
            var requestNumber = (userRequest.From).ToString().Split("+1")[1];
            // response.Message($"Hello, {userRequest.From}!");

            if (_context.Category.Select(x => x.Name).Contains(requestBody)) //& userNumber.Contains(requestNumber))
            {
                var userCategoryAmount = _context.Category.Where(x => x.Name == requestBody).Select(x => x.BudgetedAmount);
                response.Message("Your budgeted amount for " + requestBody + " is " + userCategoryAmount);
            }
            else
            {
                response.Message("Sorry, you got the wrong number.");
            }

            return TwiML(response);
          
        }
    }
}