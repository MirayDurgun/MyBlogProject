using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Certificate
    {
        public int CertificateId { get; set; }
        public string? CertificateName { get; set; }
        public string? CertificationInstitution { get; set; } //sertifikanın alındığı kurum 
        public string? CertificateDescription { get; set; } //eğitim açıklaması mesela eğitim süresi yazılabilir
        public DateTime? CertificateStartDate { get; set; }
        public DateTime? CertificateEndDate { get; set; }
        public DateTime? EducationDurationHours { get; set; } //eğitim süresi
    }
}
