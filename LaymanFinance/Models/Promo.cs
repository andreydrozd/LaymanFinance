using System;
using System.Collections.Generic;

namespace LaymanFinance.Models
{
    public partial class Promo
    {
        public Promo()
        {
            ServiceDetail = new HashSet<ServiceDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public decimal PercentageOff { get; set; }

        public ICollection<ServiceDetail> ServiceDetail { get; set; }
    }
}
