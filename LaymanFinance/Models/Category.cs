using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LaymanFinance.Models
{
    public class Category
    {
        public Category()
        {
            Transaction = new HashSet<Transaction>();
            UserCategory = new HashSet<UserCategory>();
        }

        [Required(ErrorMessage = "Choose a category.")]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ForOutlays { get; set; }
        public bool ForInflows { get; set; }
        public bool? IsDiscretionary { get; set; }

        // These are the relationships of Category
        public ICollection<Transaction> Transaction { get; set; }
        public ICollection<UserCategory> UserCategory { get; set; }
    }
}
