using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LaymanFinance.Models
{
    public partial class Outlay
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = "When was the outlay?")]
        public DateTime DateOccurred { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? DateModified { get; set; }

        [Required(ErrorMessage = "You didn't say how much the outlay was.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Who took thy money?")]
        public string Payee { get; set; }

        [Required(ErrorMessage = "We got the Who, What, When. Add a Where or Why.")]
        public string Memo { get; set; }

        public Category Category { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
