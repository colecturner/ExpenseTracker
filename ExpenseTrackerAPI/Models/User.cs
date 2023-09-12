using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerAPI.Models
{
    public class User : IdentityUser
    {
        public DateTime DateRegistered { get; set; } = DateTime.Now;

        // Navigation property
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
