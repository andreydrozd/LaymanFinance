using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class InflowModel
    {
        public int ID { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "When was the inflow?")]
        public DateTime? Date { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "You didn't say how much the inflow was.")]
        public decimal Amount { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Who gave thee money?")]
        public string Payor { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "We got the Who,What,When. Add a Where or Why.")]
        public string Memo { get; set; }

        public CategoryModel Category { get; set; }
    }
}
