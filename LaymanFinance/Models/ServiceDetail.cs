using System;
using System.Collections.Generic;

namespace LaymanFinance.Models
{
    public partial class ServiceDetail
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int PromoId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public Promo Promo { get; set; }
        public Service Service { get; set; }
    }
}
