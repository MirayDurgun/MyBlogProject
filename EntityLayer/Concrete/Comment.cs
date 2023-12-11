using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public string Image { get; set; }
        public DateTime CommentDate { get; set; } = DateTime.Now;

        //blog
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
