using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Bio { get; set; }
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [Required, Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }
        public bool RecieveNewsletters { get; set; } = false;
        [Range(typeof(bool), "true", "true", ErrorMessage = "Please accept Ts and Cs to register!")]
        public bool ReadTsAndCs { get; set; } = false;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public bool IsConfirmed { get; set; } = false;

    }
}
