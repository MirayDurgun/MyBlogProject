using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } //ilişkili tablolarda silme işlemi problem olduğundan,
                                                 //bir categoryi silmek yerine aktif ya da pasif duruma
                                                 //getireceğiz bu nedenle CategoryStatus kullanıyoruz.
                                                 //bool iki tane ihtimalin olduğu yerlerde kullanılır evet ya da hayır gibi.
    }
}
