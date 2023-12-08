using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactUserName { get; set; }
        public string ContactMail { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDate { get; set; } = DateTime.Now;
        public bool ContactStatus { get; set; }
    }
}
