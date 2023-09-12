using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Helpers
{
    public class LoginDTO
    {
        [Required]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
