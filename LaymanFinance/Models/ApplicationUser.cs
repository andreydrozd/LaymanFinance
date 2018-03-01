using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LaymanFinance.Models
{
    // This adds extra columns to the User table
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }

        // These are the one-to-many relationships of Category
        // public ICollection<> { get; set; }
        // public ICollection<> { get; set; }
    }
}
