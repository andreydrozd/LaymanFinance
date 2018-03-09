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
            Outlay = new HashSet<Outlay>();
            Inflow = new HashSet<Inflow>();
            Transaction = new HashSet<Transaction>();
        }

        // This adds extra columns to the User table
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Outlay> Outlay { get; set; }
        public ICollection<Inflow> Inflow { get; set; }
        public ICollection<Transaction> Transaction { get; set; }

        // TODO: Connect users to their respective services.
        // public ICollection<ServiceDetail> ServiceDetail { get; set; }
        // public ICollection<Order> Order { get; set; }
    }
}
