using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ParentComment
    {
        public int ParentCommentId { get; set; }
        public string ParentCommentUserName { get; set; }
        public string ParentCommentContent { get; set; }
        public string? ParentImage { get; set; }
        public DateTime ParentCommentDate { get; set; } = DateTime.Now;

        public int? CommentId { get; set; }

    }
}
