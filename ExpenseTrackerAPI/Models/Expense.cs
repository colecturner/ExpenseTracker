using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }

        public int UserId { get; set; }      // FK for User
        public User User { get; set; }       // Navigation property

        public int CategoryId { get; set; }  // FK for Category
        public Category Category { get; set; } // Navigation property

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime DateIncurred { get; set; }
    }
}
