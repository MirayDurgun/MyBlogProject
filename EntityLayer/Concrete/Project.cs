using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectSummary { get; set; } //proje özet açıklama
        public string ProjectDescription { get; set; } //hangi teknolojiler kullanıldı
    }
}
