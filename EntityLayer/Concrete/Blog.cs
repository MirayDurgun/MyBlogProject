﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }= DateTime.Now;
        public bool BlogStatus { get; set; }

    //blog reminin altına category tablosundan hangi kategoriye ait olduğu çekilecek
       
    }
}
