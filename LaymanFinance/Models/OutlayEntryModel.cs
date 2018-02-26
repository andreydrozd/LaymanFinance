using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class OutlayEntryModel
    {
        public Outlay Outlay { get; set; }
        public CategoryModel[] Categories { get; set; }
    }
}
