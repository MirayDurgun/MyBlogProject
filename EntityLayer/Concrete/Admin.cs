using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        public int AdminID { get; set; }

        [Required(ErrorMessage = "Ad Soyad boş geçilemez")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad Soyad en az 3, en fazla 50 karakter içermelidir")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Özet açıklama boş geçilemez")]
        [StringLength(500, MinimumLength = 150, ErrorMessage = "Özet açıklama en az 150, en fazla 500 karakter içermelidir")]
        public string ShortDescription { get; set; }
        public string? Description { get; set; }
        public string? Description2 { get; set; }

        [Required(ErrorMessage = "Fotoğraf boş geçilemez")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Rol boş geçilemez")]
        [MinLength(3, ErrorMessage = "Ad Soyad en az 3 karakter içermelidir")]
        public string Role { get; set; }
    }
}
