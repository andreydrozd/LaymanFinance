using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class CategoryModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Choose a category.")]
        public int? ID { get; set; }

        public string Name { get; set; }
        public double BudgetedAmount { get; set; }
        public double ActivityAmount { get; set; }
        public double AvailableAmount { get; set; }
        public Outlay[] Outlays { get; set; }
        public InflowModel[] Inflows { get; set; }
    }
}
