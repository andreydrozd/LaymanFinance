using System;
using System.Collections.Generic;

namespace LaymanFinance.Models
{
    public partial class Service
    {
        public Service()
        {
            ServiceDetail = new HashSet<ServiceDetail>();
            Testimonial = new HashSet<Testimonial>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string DescriptionOne { get; set; }
        public string DescriptionTwo { get; set; }
        public string DescriptionThree { get; set; }
        public string DescriptionFour { get; set; }


        public ICollection<ServiceDetail> ServiceDetail { get; set; }
        public ICollection<Testimonial> Testimonial { get; set; }
    }
}
