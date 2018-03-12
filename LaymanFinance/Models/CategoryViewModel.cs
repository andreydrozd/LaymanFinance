using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class CategoryViewModel
    {
        public ICollection<Category> Inflows { get; set; }
        public ICollection<Category> Outlays { get; set; }
    }
}
