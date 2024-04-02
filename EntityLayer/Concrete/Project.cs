using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Proje adı boş geçilemez")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Proje adı en az 5, en fazla 250 karakter içermelidir")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Özet bilgi boş geçilemez")]
        [StringLength(500, MinimumLength = 25, ErrorMessage = "Özet bilgi en az 25, en fazla 500 karakter içermelidir")]
        public string? ProjectSummary { get; set; } //proje özet açıklama

        public string? ProjectDescription { get; set; } //hangi teknolojiler kullanıldı
        public string? ProjectDescription2 { get; set; } //hangi teknolojiler kullanıldı 2



        [Required(ErrorMessage = "Proje tamamlanma yüzdesi boş geçilemez")]
        [Range(0, 100, ErrorMessage = "Proje tamamlanma yüzdesi 0 ile 100 arasında olmalıdır")]
        public int ProjectCompletion { get; set; } //tamamlanma yüzdesi
        public bool ProjectStatus { get; set; } 
        public string? Video { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public string? Image5 { get; set; }
        public string? Image6 { get; set; }
        public string? Image7 { get; set; }
        public string? Image8 { get; set; }
        public string? Image9 { get; set; }
        public string? Image10 { get; set; }
        public string? Image11 { get; set; }
        public string? Image12 { get; set; }
        public string? Image13 { get; set; }
        public string? Image14 { get; set; }
        public string? Image15 { get; set; }
        public string? Image16 { get; set; }
        public string? Image17 { get; set; }
        public string? Image18 { get; set; }
        public string? Image19 { get; set; }
        public string? Image20 { get; set; }

    }
}
