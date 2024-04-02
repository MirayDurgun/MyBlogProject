using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        public int EducationId { get; set; }

        [Required(ErrorMessage = "Bölüm adı boş geçilemez")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Bölüm adı en az 5, en fazla 250 karakter içermelidir")]
        public string EducationTitle { get; set; }

        [Required(ErrorMessage = "Okul adı boş geçilemez")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Okul adı en az 5, en fazla 250 karakter içermelidir")]
        public string EducationName { get; set; }
        public string? EducationDescription { get; set; }

        [Required(ErrorMessage = "Başlangıç tarihi boş geçilemez")]
        public DateTime EducationStartDate { get; set; } //okula giriş
        public DateTime? EducationEndDate { get; set; } //okula çıkış
        public string? ContinuingEducation { get; set; } //okula devam ediyorsa indexe checkbox ile tercih seçeneği çıkarılabilir



    }
}
