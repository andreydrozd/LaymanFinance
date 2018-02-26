using System;
using System.Collections.Generic;

namespace LaymanFinance.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
