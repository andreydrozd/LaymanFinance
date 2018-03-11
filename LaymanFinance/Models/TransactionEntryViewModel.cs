using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class TransactionEntryViewModel
    {
        public Transaction Transaction { get; set; }
        public string SelectedCategory { get; set; }
        public string[] InflowCategories { get; set; }
        public string[] OutlayCategories { get; set; }
    }
}
