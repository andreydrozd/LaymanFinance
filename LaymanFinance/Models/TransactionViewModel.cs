using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class TransactionViewModel
    {
        public ICollection<Transaction> Transactions { get; set; }
        public decimal AcutalOutlays { get; set; }
        public decimal BudgetOutlays { get; set; }
        public string OutlayTotals { get; set; }
        public string OutlayTotalsBudget { get; set; }
        public string TransactionTotals { get; set; }
        public string[] Categories { get; set; }
    }
}
