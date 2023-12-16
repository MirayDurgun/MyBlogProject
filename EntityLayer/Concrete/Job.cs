using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; } //işe giriş
        public DateTime? EndDate { get; set; } //işten çıkış
        public string? ContinuingJob { get; set; } //iş devam ediyor mu?


        //portfolio
        public List<Portfolio> Portfolios { get; set; }
    }
}
