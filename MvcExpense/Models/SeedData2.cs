using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcExpense.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcExpense.Models
{
    public class SeedData2
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcIncomeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcIncomeContext>>()))
            {
                // Look for any incomes.
                if (context.Income.Any())
                {
                    return;   // DB has been seeded
                }

                context.Income.AddRange(
                    new Income
                    {
                        ItemName = "Web Developer",
                        IncomeDate = DateTime.Parse("01.02.2021"),
                        Category = "Salary",
                        Amount = 1200
                    },

                    new Income
                    {
                        ItemName = "Express Bank ",
                        IncomeDate = DateTime.Parse("07.08.2019"),
                        Category = "Deposit",
                        Amount = 7800
                    },

                    new Income
                    {
                        ItemName = "SpaceX",
                        IncomeDate = DateTime.Parse("02.05.2020"),
                        Category = "Dividends",
                        Amount = 2340
                    },

                    new Income
                    {
                        ItemName = "OTP Bank",
                        IncomeDate = DateTime.Parse("12.03.2020"),
                        Category = "Savings",
                        Amount = 12050
                    }
                );
                context.SaveChanges();
            }
        }
    }
}


