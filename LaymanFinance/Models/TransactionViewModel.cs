using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class TransactionViewModel
    {
        public ICollection<Transaction> Transactions { get; set; }
        public string [] Categories { get; set; }
    }
}
