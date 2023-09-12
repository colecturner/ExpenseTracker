using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Helpers
{
    public class RegisterDTO
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}

