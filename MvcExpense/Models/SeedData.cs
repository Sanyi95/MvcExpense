using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcExpense.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcExpense.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcExpenseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcExpenseContext>>()))

            {
                // Look for any expenses.
                if (context.Expense.Any())
                {
                    return;   // DB has been seeded
                }

                context.Expense.AddRange(
                    new Expense
                    {
                        ItemName = "Gucci",
                        ExpenseDate = DateTime.Parse("01.12.2021"),
                        Category = "Clothes",
                        Amount = 200
                    },

                    new Expense
                    {
                        ItemName = "Electricity ",
                        ExpenseDate = DateTime.Parse("02.10.2021"),
                        Category = "Bills",
                        Amount = 450
                    },

                    new Expense
                    {
                        ItemName = "Volvo S90",
                        ExpenseDate = DateTime.Parse("02.12.2021"),
                        Category = "Car",
                        Amount = 3500
                    },

                    new Expense
                    {
                        ItemName = "Veggies",
                        ExpenseDate = DateTime.Parse("03.12.2021"),
                        Category = "Food",
                        Amount = 320
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

