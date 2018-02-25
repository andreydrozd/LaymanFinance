using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class OutlayModel
    {
        public int ID { get; set; }


        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "When was the outlay?")]
        public DateTime? Date { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "You didn't say how much the outlay was.")]
        public decimal Amount { get; set; }
    
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Who took thy money?")]
        public string Payee { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "We got the Who,What,When. Add a Where or Why.")]
        public string Memo { get; set; }

        public CategoryModel Category { get; set; }
    }
}
