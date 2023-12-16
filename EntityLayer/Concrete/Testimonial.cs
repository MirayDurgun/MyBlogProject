using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string TestimonialsName { get; set; }
        public string TestimonialsJobTitle { get; set; }
        public string TestimonialsCompanyName { get; set; }
        public string? TestimonialsDescription { get; set; }


    }
}
