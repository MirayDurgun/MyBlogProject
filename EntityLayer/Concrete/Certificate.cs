using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Certificate
    {
        public int CertificateId { get; set; }

        [Required(ErrorMessage = "Sertifika adı boş geçilemez")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Sertifika adı en az 5, en fazla 250 karakter içermelidir")]
        public string CertificateName { get; set; }

        [Required(ErrorMessage = "Alınan kurum boş geçilemez")]
        [StringLength(350, MinimumLength = 5, ErrorMessage = "Alınan kurum en az 5, en fazla 350 karakter içermelidir")]
        public string CertificationInstitution { get; set; } //sertifikanın alındığı kurum 
        public string? CertificateDescription { get; set; } //eğitim açıklaması mesela eğitim süresi yazılabilir
        public DateTime? CertificateStartDate { get; set; }
        public DateTime? CertificateEndDate { get; set; }
        public string? EducationDurationHours { get; set; } //eğitim süresi


    }
}
