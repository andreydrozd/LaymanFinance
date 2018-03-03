using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LaymanFinance.Models
{
    public partial class Inflow
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = "When was the inflow?")]
        public DateTime DateOccurred { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? DateModified { get; set; }

        [Required(ErrorMessage = "How much did you get?")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Who gave thee money?")]
        public string Payor { get; set; }

        [Required(ErrorMessage = "We got the Who, What, When. Add a Where or Why.")]
        public string Memo { get; set; } 

        public Category Category { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
