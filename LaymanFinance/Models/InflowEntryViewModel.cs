using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class InflowEntryViewModel
    {
        public Inflow Inflow { get; set; }
        public string SelectedCategory { get; set; }
        public string[] Categories { get; set; }
    }
}
