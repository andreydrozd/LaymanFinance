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
        }

        [Required(ErrorMessage = "Choose a category.")]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BudgetedAmount { get; set; }
        public bool ForOutlays { get; set; }
        public bool ForInflows { get; set; }
        public bool? IsDiscretionary { get; set; }

        // These are the one-to-many relationships of Category
        public ICollection<Transaction> Transaction { get; set; }
    }
}
