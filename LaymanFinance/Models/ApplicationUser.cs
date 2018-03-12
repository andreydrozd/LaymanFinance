using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LaymanFinance.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser ()
        {
            Transaction = new HashSet<Transaction>();
            UserCategories = new HashSet<UserCategory>();
        }

        // This adds extra columns to the User table
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Transaction> Transaction { get; set; }
        public ICollection<UserCategory> UserCategories { get; set; }

        // TODO: Connect users to their respective services.
        // public ICollection<ServiceDetail> ServiceDetail { get; set; }
        // public ICollection<Order> Order { get; set; }
    }
}
