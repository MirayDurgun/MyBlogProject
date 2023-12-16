using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        public int EducationId { get; set; }
        public string EducationTitle { get; set; }
        public string EducationName { get; set; }
        public string? EducationDescription { get; set; }  
        public DateTime EducationStartDate { get; set; } //okula giriş
        public DateTime? EducationEndDate { get; set; } //okula çıkış
        public string? ContinuingEducation { get; set; } //okula devam ediyorsa indexe checkbox ile tercih seçeneği çıkarılabilir


        //portfolio
        public List<Portfolio> Portfolios { get; set; }

    }
}
