using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public DateTime DateRegistered { get; set; }

        // Navigation property
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
