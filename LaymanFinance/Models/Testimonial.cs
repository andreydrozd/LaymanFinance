using System;
using System.Collections.Generic;

namespace LaymanFinance.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public string TextOne { get; set; }
        public string TextTwo { get; set; }
        public string TextThree { get; set; }

        public Service Service { get; set; }
    }
}
