using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; }

        // Navigation property
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
