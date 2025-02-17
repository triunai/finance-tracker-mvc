using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FinanceTrackerMVC.Domain.Enums;

namespace FinanceTrackerMVC.Domain.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount => ExpenseItems.Sum(item => item.Price * item.Quantity);
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public int? CreatedByUserId { get; set; }
        public int? UpdatedByUserId { get; set; }

        public virtual ICollection<ExpenseItem> ExpenseItems { get; set; }
    }
}
