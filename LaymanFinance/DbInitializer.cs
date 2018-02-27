﻿using System;
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
                context.Category.Add(new Category
                {
                    Name = "Housing",
                    BudgetedAmount = 700,
                });

                context.Category.Add(new Category
                {
                    Name = "Groceries",
                    BudgetedAmount = 200,
                });

                context.Category.Add(new Category
                {
                    Name = "Transportation",
                    BudgetedAmount = 200,
                });

                context.Category.Add(new Category
                {
                    Name = "Investments",
                    BudgetedAmount = 1000,
                });

                context.Category.Add(new Category
                {
                    Name = "Charity",
                    BudgetedAmount = 140,
                });

                context.Category.Add(new Category
                {
                    Name = "Discretionary",
                    BudgetedAmount = 400,
                });

                context.Category.Add(new Category
                {
                    Name = "Phone",
                    BudgetedAmount = 60,
                });

                //Finally, SaveChanges on the Context to commit these to the database
                context.SaveChanges();
            }

            if(!context.Service.Any())
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
