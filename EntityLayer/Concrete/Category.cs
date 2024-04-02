using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Kategori adı boş geçilemez")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Kategori adı en az 3, en fazla 50 karakter içermelidir")]
        public string CategoryName { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
