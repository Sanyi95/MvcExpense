using Microsoft.EntityFrameworkCore;
using MvcExpense.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcExpense.Data
{
    public class MvcExpenseContext : DbContext
    {
        public MvcExpenseContext(DbContextOptions<MvcExpenseContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expense { get; set; }
    }
}
