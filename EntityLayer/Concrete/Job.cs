using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Job
    {
        public int JobId { get; set; }

        [Required(ErrorMessage = "Ünvan boş geçilemez")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Ünvan en az 5, en fazla 250 karakter içermelidir")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Şirket adı boş geçilemez")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Şirket adı en az 3, en fazla 250 karakter içermelidir")]
        public string CompanyName { get; set; }

        public string? Description { get; set; }
        public DateTime? StartDate { get; set; } //işe giriş
        public DateTime? EndDate { get; set; } //işten çıkış
        public bool ContinuingJob { get; set; } //iş devam ediyor mu?



    }
}
