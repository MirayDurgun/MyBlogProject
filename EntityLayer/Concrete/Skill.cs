using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        public int SkillId { get; set; }

        [Required(ErrorMessage = "Yetkinlik adı boş geçilemez")]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "Yetkinlik adı en az 1, en fazla 250 karakter içermelidir")]
        public string SkillName { get; set; }

        [Range(0, 100, ErrorMessage = "Yetkinlik yüzdesi 0 ile 100 arasında olmalıdır")]
        public string? SkillScore { get; set; }
    }
}
