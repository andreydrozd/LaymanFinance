using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaymanFinance.Models;

namespace LaymanFinance.Models
{
    public class LedgerViewModel
    {
        public Outlay[] Outlay { get; set; }
        public Inflow[] Inflow { get; set; }
    }
}
