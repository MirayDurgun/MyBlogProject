using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string NameTitle { get; set; }
        
        //  public string FieldTitle { get; set; } // okul iş kısımlarını ayıran büyük başlık kısmı
        public DateTime StartDate { get; set; } //işe giriş
        public DateTime? EndDate { get; set; } //işten çıkış
        public string? JobTitle { get; set; }
        public string? CompanyName { get; set; }
        public string? Description { get; set; }
        public string? PortfolioTitle { get; set; }

        //yetkinlikler
        public string SkillName { get; set; }
        public string? SkillScore { get; set; }
        public string? SoftwareUsed { get; set; } //kullandığım programlar

        // projeler sayfasından gelsin özet açıklama ve proje adını çekersin
        public List<Project> Projects { get; set; }

        //sertifikalar
        public string? CertificateName { get; set; }
        public string? CertificationInstitution { get; set; } //sertifikanın alındığı kurum 
        public string? CertificateDescription { get; set; }
        public DateTime? CertificateStartDate { get; set; }
        public DateTime? CertificateEndDate { get; set; }
        public DateTime? EducationDurationHours { get; set; } //eğitim süresi

        //referanslar
        public string? TestimonialsName { get; set; }
        public string? TestimonialsJobTitle { get; set; }
        public string? TestimonialsDescription { get; set; }

        //hakkımızda ilişkilendirildi
        public List<About> Abouts { get; set; }
    }
}
