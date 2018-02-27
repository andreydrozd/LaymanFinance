using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class OutlayEntry
    {
        public int ID { get; set; }
        public Outlay Outlay { get; set; }
        public Category Category { get; set; }
    }
}
