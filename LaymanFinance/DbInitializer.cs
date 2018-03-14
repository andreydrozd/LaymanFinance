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
                    BudgetedAmount = 80,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Electricity",
                    BudgetedAmount = 75,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Water",
                    BudgetedAmount = 50,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Internet",
                    BudgetedAmount = 50,
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
                    Name = "Auto Maintenance and Insurance",
                    BudgetedAmount = 400,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Home Maintenance",
                    BudgetedAmount = 300,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Medical",
                    BudgetedAmount = 100,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Gifts",
                    BudgetedAmount = 75,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Eating Out",
                    BudgetedAmount = 200,
                    ForInflows = false,
                    ForOutlays = true,
                    IsDiscretionary = true
                });

                context.Category.Add(new Category
                {
                    Name = "Entertainment",
                    BudgetedAmount = 100,
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
                    Name = "Investment Income",
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
                    DateOccurred = new DateTime(2017, 9, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Labor Day day trip fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });
                
                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid August cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 12
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 32.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 7),
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
                    DateOccurred = new DateTime(2017, 9, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.41M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 4.59M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 28.03M,
                    Source = "Toy R Us",
                    Memo = "Angelina's 11th birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 65.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned tuna, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.32M,
                    Source = "Chipotle",
                    Memo = "Lunch with Laura.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "September brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 11
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "September IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 11
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for mom.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "September monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "September monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Saturday is for the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Dan's BBQ",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 86.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "CVS",
                    Memo = "Starbucks gift card for John's birthday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.65M,
                    Source = "El Famous Burrito",
                    Memo = "Lunch after church.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 13
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of September.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of September",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Chelsea-Bayern CL game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 178.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the GE stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 2
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 9, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });


                // OCTOBER TRANSACTIONS

                // 1
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Regular fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid September cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 12
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 32.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 7),
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
                    DateOccurred = new DateTime(2017, 10, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.41M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 4.59M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 28.03M,
                    Source = "Toy R Us",
                    Memo = "Lucas's 8th birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 65.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned tuna, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.32M,
                    Source = "Chipotle",
                    Memo = "Lunch with Laura.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "October brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 11
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "October IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 11
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for dad.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "October monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "October monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Saturday is for the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Allison's get-together.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 86.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "CVS",
                    Memo = "Starbucks gift card for Alison's birthday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.65M,
                    Source = "El Famous Burrito",
                    Memo = "Lunch after church.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 13
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of October.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of October",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Chelsea-Tottenham game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 178.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the GE stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 2
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 10, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });


                // NOVEMBER TRANSACTIONS

                // 1
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Regular fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid October cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 12
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 22.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 7),
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
                    DateOccurred = new DateTime(2017, 11, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 5.95M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3.47M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 28.03M,
                    Source = "Toy R Us",
                    Memo = "Eleazar's 7th birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 51.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 27.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned tuna, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 8.90M,
                    Source = "Chipotle",
                    Memo = "Lunch with Amy.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "November brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 2
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "November IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 2
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for Vadim.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "November monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "November monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Saturday is for the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Jason's get-together.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 86.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "CVS",
                    Memo = "Starbucks gift card for Ben's birthday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.65M,
                    Source = "El Famous Brunch",
                    Memo = "Brunch on Black Wednesday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 12
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of November.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of November",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Man City-Man U game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 178.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the MSFT stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 2
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 11, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });


                // DECEMBER TRANSACTIONS

                // 1
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Regular fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid November cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 12
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 22.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 700,
                    Source = "Rent",
                    Memo = "December rent",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 6
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 5.95M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.47M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 37.03M,
                    Source = "Toy R Us",
                    Memo = "Eleazar's 7th birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 77.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 17.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned beans, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 8.90M,
                    Source = "Chipotle",
                    Memo = "Lunch with Amy.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "December brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 2
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "December IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 2
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for Vadim.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "December monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "December monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Christmas with the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Jason's Christmas party.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Got the Christmas turkey",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 86.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 26),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "CVS",
                    Memo = "Christmas gift card for Ben.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 27),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.65M,
                    Source = "El Famous Brunch",
                    Memo = "Lunch after church.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 12
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of November.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of November",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Man City-Man U game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 178.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the MSFT stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 2
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2017, 12, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });


                // JANUARY TRANSACTIONS

                // 1
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Regular fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid December cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 12
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 32.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 700,
                    Source = "Rent",
                    Memo = "January rent",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 6
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.41M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 4.59M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 32.33M,
                    Source = "Toy R Us",
                    Memo = "Evnikas's 3rd birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 65.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned tuna, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 8.32M,
                    Source = "Chipotle",
                    Memo = "Lunch with Jake.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "January brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 2
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "January IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 2
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for Vadim.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "January monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "January monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Saturday is for the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Jason's get-together.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 86.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 30,
                    Source = "CVS",
                    Memo = "Starbucks gift card for Lane's birthday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 9.65M,
                    Source = "El Famous Brunch",
                    Memo = "Dinner after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 13
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of January.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of January",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Man City-Man U game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 178.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the TSLA stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 2
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });


                // FEBRUARY TRANSACTIONS

                // 1
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 33.45M,
                    Source = "Shell",
                    Memo = "Regular fill-up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 3),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.56M,
                    Source = "Chickfila",
                    Memo = "Lunch with Steve.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 55.98M,
                    Source = "Sprint",
                    Memo = "Paid January cell bill",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 12
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 5),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 32.09M,
                    Source = "Shell",
                    Memo = "Fillup",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 16
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 700,
                    Source = "Rent",
                    Memo = "January rent",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 6
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 7),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.41M,
                    Source = "Subway",
                    Memo = "Lunch with David.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 4.59M,
                    Source = "Mcd",
                    Memo = "Too lazy to make breakfast.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 9),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.12M,
                    Source = "Toy R Us",
                    Memo = "Eneya's 1st birthday gift.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.84M,
                    Source = "Mariano's",
                    Memo = "Usual groceries",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 11),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 65.23M,
                    Source = "Mariano's",
                    Memo = "Mariano's had a sale on canned tuna, so I had to stock up.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 8.32M,
                    Source = "Chipotle",
                    Memo = "Lunch with Jake.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 13),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 2.38M,
                    Source = "Argo Tea",
                    Memo = "Green tea after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 4, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10.23M,
                    Source = "YouTube Red",
                    Memo = "YouTube Red subscription",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 11, 15),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 400,
                    Source = "Vanguard",
                    Memo = "February brokerage account contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 2
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 500,
                    Source = "Vanguard",
                    Memo = "February IRA contribution",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 2
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 17),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 50,
                    Source = "CVS",
                    Memo = "Birthday gift for Vadim.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "MAP International",
                    Memo = "February monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 1, 19),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 40,
                    Source = "Moody Global Ministries",
                    Memo = "February monthly donation",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 18
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 34.12M,
                    Source = "Buffalo Wild Wings",
                    Memo = "Saturday is for the boys.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 21),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 12.39M,
                    Source = "Binny's",
                    Memo = "6-pack for Jason's get-together.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 4
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 18.23M,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 23),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 62.19M,
                    Source = "Mariano's",
                    Memo = "Regular grocery haul.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 17
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 25,
                    Source = "CVS",
                    Memo = "Starbucks gift card for Eric's birthday.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 6
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 7.63M,
                    Source = "El Famous Brunch",
                    Memo = "Dinner after work.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 5
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 25),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 60.87M,
                    Source = "Comcast",
                    Memo = "Internet bill.",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 13
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 2),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "First paycheck of February.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 18),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 3500,
                    Source = "Drozd Dev",
                    Memo = "Second paycheck of February",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 3
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 16),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 10,
                    Source = "Frank the Tank",
                    Memo = "Won a bet on the Man City-Man U game.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 28),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 123.39M,
                    Source = "Robinhood",
                    Memo = "Made some money on the TSLA stock bounceback.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 2
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 2, 20),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 47.06M,
                    Source = "Lyft",
                    Memo = "Lyft payout.",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 9
                });



                //Finally, SaveChanges on the Context to commit these to the database
                context.SaveChanges();
            }
        }
    }
}
