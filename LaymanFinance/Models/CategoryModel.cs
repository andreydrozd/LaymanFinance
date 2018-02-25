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
        public double Activity { get; set; }
        public double Available { get; set; }
        public OutlayModel[] Outlays { get; set; }
    }
}
