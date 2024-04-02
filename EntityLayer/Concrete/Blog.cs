using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }

        [Required(ErrorMessage = "Başlık boş geçilemez")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ad Soyad en az 3, en fazla 50 karakter içermelidir")]
        public string BlogTitle { get; set; }

        [Required(ErrorMessage = "Açıklama boş geçilemez")]
        [StringLength(700, MinimumLength = 350, ErrorMessage = "Açıklama en az 350, en fazla 700 karakter içermelidir")]
        public string BlogContent { get; set; }
        public string? BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; } = DateTime.Now;
        public bool BlogStatus { get; set; }

        //blog resminin altına category tablosundan hangi kategoriye ait olduğu çekilecek
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        //bir bloga birden fazla yprum yapılabilir
        public virtual List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
