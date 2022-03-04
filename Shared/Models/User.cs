using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; } //Remove, unnecessary
        public List<Favorite> Favorites { get; set; } = new List<Favorite>();
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool RecieveNewsletters { get; set; } = false;
        public bool ReadTsAndCs { get; set; } = false;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public bool IsConfirmed { get; set; } = false;
    }
}
