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
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Investments",
                    BudgetedAmount = 100,
                    ForInflows = true,
                    ForOutlays = false,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Sidehustle",
                    BudgetedAmount = 500,
                    ForInflows = true,
                    ForOutlays = false,
                    IsDiscretionary = false
                });

                context.Category.Add(new Category
                {
                    Name = "Presents",
                    BudgetedAmount = 0,
                    ForInflows = true,
                    ForOutlays = false,
                    IsDiscretionary = false
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
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });
                
                // 2
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 3
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 4
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 5
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 6
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 7
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 8
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 9
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 10
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 11
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 12
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 13
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 14
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 15
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 16
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 17
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 18
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 19
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 20
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 21
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 22
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 23
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 24
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 25
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = false,
                    IsOutlay = true,
                    CategoryId = 1
                });

                // 1I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 2I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 3I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 4I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
                    IsInflow = true,
                    IsOutlay = false,
                    CategoryId = 1
                });

                // 5I
                context.Transaction.Add(new Transaction
                {
                    DateOccurred = new DateTime(2018, 3, 8),
                    DateEntered = DateTime.Now,
                    DateModified = null,
                    Amount = 20,
                    Source = "Whole Foods",
                    Memo = "Testing the difference between Whole Foods and Mariano's meat",
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
