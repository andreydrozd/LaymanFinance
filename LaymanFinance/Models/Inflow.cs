using System;
using System.Collections.Generic;

namespace LaymanFinance.Models
{
    public partial class Inflow
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateOccurred { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public decimal Amount { get; set; }
        public string Payor { get; set; }
        public string Memo { get; set; }

        public Category Category { get; set; }
    }
}
