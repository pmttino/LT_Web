using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace tinoshop_demo2.Models
{
    public class User
    {
        public User()
        {
            UserRole = "Customer";
        }
        [Key]
        public int UserID { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? UserEmail { get; set; }
        [Required]
        public string? UserPassword { get; set; }
        
        public string? UserRole { get; set; }
    }
}
