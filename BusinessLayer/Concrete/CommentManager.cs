using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void CommentAdd(Comment comment)
        {
           _commentDal.Insert(comment);
        }

        public List<Comment> GetCommentListWithBlog()
        {
            return _commentDal.GetListWithBlog();
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetListAll();
        }
    }
}
