using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string? SkillScore { get; set; }
        public string? SoftwareUsed { get; set; } //kullandığım programlar

    }
}
