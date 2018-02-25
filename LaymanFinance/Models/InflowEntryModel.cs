using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class InflowEntryModel
    {
        public InflowModel Inlay { get; set; }
        public CategoryModel[] Categories { get; set; }
    }
}
