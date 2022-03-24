using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MovieCruiser.Api.Models
{
    public class AppUser
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and Confirm Password does not match.")]
        public string ConfirmPassword { get; set; }
    }
}
