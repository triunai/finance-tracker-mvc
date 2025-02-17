using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinanceTrackerMVC.Application.DTOs;
using FinanceTrackerMVC.Domain.Enums; // Make sure this namespace is correct

namespace FinanceTrackerMVC.Web.Controllers.Expenses
{
    public class ExpensesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            // Mock data
            var mockExpenses = new List<ExpenseDto>
            {
                new ExpenseDto
                {
                    Id = 1,
                    Description = "Groceries",
                    Amount = 120.50m,
                    PaymentMethod = PaymentMethod.Cash,
                    ExpenseDate = DateTime.Now.AddDays(-5)
                },
                new ExpenseDto
                {
                    Id = 2,
                    Description = "Internet Bill",
                    Amount = 45.00m,
                    PaymentMethod = PaymentMethod.EWallet,
                    ExpenseDate = DateTime.Now.AddDays(-3)
                },
                new ExpenseDto
                {
                    Id = 3,
                    Description = "Transportation",
                    Amount = 85.75m,
                    PaymentMethod = PaymentMethod.CreditCard,
                    ExpenseDate = DateTime.Now
                }
            };

            // Pass mock data to the view
            return View(mockExpenses);
        }
    }
}