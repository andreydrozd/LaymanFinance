using System;
using System.Collections.Generic;

namespace LaymanFinance.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public Promo Promo { get; set; }
    }
}
