using FinanceTrackerMVC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTrackerMVC.Infrastructure
{
    public class FinanceTrackerContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Expense>()
                .HasMany(e => e.ExpenseItems)
                .WithOne(i => i.Expense)
                .HasForeignKey(i => i.ExpenseId);

            modelBuilder.Entity<ExpenseItem>()
                .HasOne(i => i.Category)
                .WithMany(c => c.ExpenseItems)
                .HasForeignKey(i => i.CategoryId);
        }
    }
}
