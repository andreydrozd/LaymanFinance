﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaymanFinance.Models
{
    public class OutlayEntryViewModel
    {
        public Outlay Outlay { get; set; }
        public string SelectedCategory { get; set; }
        public string[] Categories { get; set; }
    }
}
