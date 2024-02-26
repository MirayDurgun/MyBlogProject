﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Mail { get; set; }
        public string NameSurname { get; set; }
        public string Password { get; set; }
        public string ShortDescription { get; set; }
        public string ImageURL { get; set; }
        public string Role { get; set; }
    }
}
