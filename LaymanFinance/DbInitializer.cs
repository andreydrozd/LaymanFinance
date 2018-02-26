using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaymanFinance.Models;

namespace LaymanFinance
{
    public class DbInitializer
    {
        internal static void Initialize(AndreyTestContext context)
        {
            //Before "seeding," make sure the database exists.
            context.Database.EnsureCreated();

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
            }
        }
    }
}
