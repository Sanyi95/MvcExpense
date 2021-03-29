using Microsoft.EntityFrameworkCore;
using MvcExpense.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcExpense.Data
{
    public class MvcIncomeContext : DbContext
    {
        public MvcIncomeContext(DbContextOptions<MvcIncomeContext> options)
            : base(options)
        {
        }

        public DbSet<Income> Income { get; set; }
    }
}


