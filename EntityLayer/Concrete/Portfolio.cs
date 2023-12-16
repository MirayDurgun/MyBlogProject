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


        //about
        public List<About> Abouts { get; set; }

        ////İŞ
        //public int? JobId { get; set; }
        //public Job Job { get; set; }


        ////EĞİTİM
        //public int? EducationId { get; set; }
        //public Education Education { get; set; }


        ////yetkinlikler
        //public int? SkillId { get; set; }
        //public Skill Skill { get; set; }


        //// projeler sayfasından gelsin özet açıklama ve proje adını çekersin
        //public int? ProjectId { get; set; }
        //public Project Project { get; set; }


        ////sertifikalar
        //public int? CertificateId { get; set; }
        //public Certificate Certificate { get; set; }


        ////referanslar
        //public int? TestimonialId { get; set; }
        //public Testimonial Testimonial { get; set; }

    }
}
