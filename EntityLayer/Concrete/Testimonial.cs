using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }

        [Required(ErrorMessage = "Referans adı boş geçilemez")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Referans adı en az 3, en fazla 250 karakter içermelidir")]
        public string TestimonialsName { get; set; }


        [Required(ErrorMessage = "Ünvan boş geçilemez")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Ünvan en az 3, en fazla 250 karakter içermelidir")]
        public string TestimonialsJobTitle { get; set; }


        [Required(ErrorMessage = "Şirket adı boş geçilemez")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Şirket adı en az 3, en fazla 250 karakter içermelidir")]
        public string TestimonialsCompanyName { get; set; }
        public string? TestimonialsDescription { get; set; }
        public string? Image { get; set; }


    }
}
