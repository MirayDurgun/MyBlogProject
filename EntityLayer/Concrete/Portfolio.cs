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

        //İŞ

        public string? ContinuingJob { get; set; }
        public string? JobTitle { get; set; }
        public string? CompanyName { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; } //işe giriş
        public DateTime? EndDate { get; set; } //işten çıkış


        //EĞİTİM
        public int? EducationId { get; set; }
        public Education Education { get; set; }


        //yetkinlikler
        public int? SkillId { get; set; }
        public Skill Skill { get; set; }


        // projeler sayfasından gelsin özet açıklama ve proje adını çekersin
        public int? ProjectId { get; set; }
        public Project Project { get; set; }


        //sertifikalar
       


        //referanslar
        public string? TestimonialsName { get; set; }
        public string? TestimonialsJobTitle { get; set; }
        public string? TestimonialsDescription { get; set; }

    }
}
