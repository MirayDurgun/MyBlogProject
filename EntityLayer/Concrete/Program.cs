using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Program
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Program adı boş geçilemez")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Program adı en az 5, en fazla 250 karakter içermelidir")]
        public string ProgramName { get; set; }
    }
}
