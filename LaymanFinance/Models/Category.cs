using System;
using System.Collections.Generic;

namespace LaymanFinance.Models
{
    public partial class Category
    {
        public Category()
        {
            Inflow = new HashSet<Inflow>();
            Outlay = new HashSet<Outlay>();
        }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Choose a category.")]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BudgetedAmount { get; set; }

        // These are the one-to-many relationships of Category
        public ICollection<Inflow> Inflow { get; set; }
        public ICollection<Outlay> Outlay { get; set; }
    }
}
