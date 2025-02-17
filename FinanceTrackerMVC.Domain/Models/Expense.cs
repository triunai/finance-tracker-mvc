using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FinanceTrackerMVC.Domain.Enums;

namespace FinanceTrackerMVC.Domain.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Description { get; set; } // Title/summary

        [Required, Range(0.01, double.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Amount { get; set; } // MYR currency

        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        public DateTime ExpenseDate { get; set; } // Date of transaction

        [MaxLength(500)]
        public string? Notes { get; set; } // Optional details

        [Column(TypeName = "datetime2")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedAt { get; set; }

        // If tracking users
        public int? CreatedByUserId { get; set; }
        public int? UpdatedByUserId { get; set; }
    }
}
