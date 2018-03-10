using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaymanFinance.Models;
using Microsoft.EntityFrameworkCore;

namespace LaymanFinance
{
    internal class DbInitializer
    {
        internal static void Initialize(AndreyTestContext context)
        {
            //Before "seeding," apply any existing migrations.
            context.Database.Migrate();

            //Once created, you can start adding records, if none exist.
            if (!context.Category.Any())
            {
                //OUTLAY TRANSACTIONS

                //NON-DISCRETIONARY
                context.Category.Add(new Category
                {
                    Name = "Housing",
                    BudgetedAmount = 700,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Groceries",
                    BudgetedAmount = 200,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Transportation",
                    BudgetedAmount = 200,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Electricity",
                    BudgetedAmount = 200,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Water",
                    BudgetedAmount = 200,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Internet",
                    BudgetedAmount = 200,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Phone",
                    BudgetedAmount = 60,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Investments",
                    BudgetedAmount = 1000,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Charity",
                    BudgetedAmount = 140,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                //DISCRETIONARY
                context.Category.Add(new Category
                {
                    Name = "Auto Maintenance",
                    BudgetedAmount = 400,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Home Maintenance",
                    BudgetedAmount = 400,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Medical",
                    BudgetedAmount = 400,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Gifts",
                    BudgetedAmount = 400,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Eating Out",
                    BudgetedAmount = 400,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Entertainment",
                    BudgetedAmount = 400,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });


                //INFLOW TRANSACTIONS
                context.Category.Add(new Category
                {
                    Name = "Wages and Salary",
                    BudgetedAmount = 7000,
                    ForInflows = true,
                    ForOutlays = false,
                    IsDiscretionary = null
                });

                context.Category.Add(new Category
                {
                    Name = "Investments",
                    BudgetedAmount = 100,
                    ForInflows = true,
                    ForOutlays = false,
                    IsDiscretionary = null
                });

                context.Category.Add(new Category
                {
                    Name = "Sidehustle",
                    BudgetedAmount = 500,
                    ForInflows = true,
                    ForOutlays = false,
                    IsDiscretionary = null
                });

                context.Category.Add(new Category
                {
                    Name = "Presents",
                    BudgetedAmount = 0,
                    ForInflows = true,
                    ForOutlays = false,
                    IsDiscretionary = null
                });

                //Finally, SaveChanges on the Context to commit these to the database
                context.SaveChanges();
            }

            if (!context.Transaction.Any())
            {
                // SEPTEMBER TRANSACTIONS

                // 1
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Labor Day day trip fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });
                
                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid August cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 32.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 700,
                    Source = "Rent",
                    Memo = "September rent",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 6
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.41M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 4.59M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 28.03M,
                    Source = "Toy R Us",
                    Memo = "Angelina's 11th birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 65.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned tuna, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.32M,
                    Source = "Chipotle",
                    Memo = "Lunch with the boss.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "September brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "September IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for mom.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "September monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "September monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Saturday is for the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Dan's BBQ",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 86.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "CVS",
                    Memo = "Starbucks gift card for John's birthday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.65M,
                    Source = "El Famous Burrito",
                    Memo = "Lunch after church.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of September.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of September",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Chelsea-Bayern CL game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 178.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the GE stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 9, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });


                // OCTOBER TRANSACTIONS

                // 1
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Regular fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid September cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 32.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 700,
                    Source = "Rent",
                    Memo = "October rent",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 6
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.41M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 4.59M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 28.03M,
                    Source = "Toy R Us",
                    Memo = "Lucas's 8th birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 65.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned tuna, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.32M,
                    Source = "Chipotle",
                    Memo = "Lunch with the boss.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "October brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "October IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for dad.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "October monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "October monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Saturday is for the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Allison's get-together.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 86.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "CVS",
                    Memo = "Starbucks gift card for Alice's birthday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.65M,
                    Source = "El Famous Burrito",
                    Memo = "Lunch after church.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of October.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of October",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Chelsea-Tottenham game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 178.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the GE stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 10, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // NOVEMBER TRANSACTIONS

                // 1
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Regular fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid October cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 32.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 700,
                    Source = "Rent",
                    Memo = "November rent",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 6
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.41M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 4.59M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 28.03M,
                    Source = "Toy R Us",
                    Memo = "Eleazar's 7th birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 65.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned tuna, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.32M,
                    Source = "Chipotle",
                    Memo = "Lunch with the boss.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "November brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "November IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for Vadim.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "November monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "November monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Saturday is for the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Jason's get-together.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 86.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "CVS",
                    Memo = "Starbucks gift card for Ben's birthday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.65M,
                    Source = "El Famous Brunch",
                    Memo = "Brunch on Black Wednesday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of November.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of November",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Man City-Man U game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 178.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the MSFT stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });


                //Finally, SaveChanges on the Context to commit these to the database
                context.SaveChanges();
            }

            if (!context.Service.Any())
            {
                context.Service.Add(new Service
                {
                    Name = "Kiddie Pool",
                    Price = 0,
                    DescriptionOne = "It's all about baby steps when it comes to saving.",
                    DescriptionTwo = "Save up to $100 a month in this pool.",
                    DescriptionThree = "Stop making monthly payments to corporations and make monthly payments to yourself! Perfect for saving up for that new smartphone.",
                    DescriptionFour = "No early withdrawals are allowed in the Kiddie Pool. You have to play in it until dinnertime."
                });

                context.Service.Add(new Service
                {
                    Name = "Above Ground Pool",
                    Price = 15,
                    DescriptionOne = "You're ready to swim with the older kids now.",
                    DescriptionTwo = "Save up to $1,000 a month in this pool.",
                    DescriptionThree = "This is the perfect pool for things like vacations and junior's first car.",
                    DescriptionFour = "Early withdrawal is available for no charge halfway through the savings cycle."
                });

                context.Service.Add(new Service
                {
                    Name = "Infinity Pool",
                    Price = 25,
                    DescriptionOne = "Step into the pool that means business.",
                    DescriptionTwo = "Save up to $2000",
                    DescriptionThree = "Price will vary depending on how large of a money pool you want to swim in.",
                    DescriptionFour = "Early withdrawal is available every 3 months throughout the savings cycle."
                });

                //Finally, SaveChanges on the Context to commit these to the database
                context.SaveChanges();
            }

        }
    }
}
