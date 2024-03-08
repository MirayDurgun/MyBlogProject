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

        public void TDelete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void TAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetCommentListWithBlog()
        {
            return _commentDal.GetListWithBlog();
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetListAll();
        }

        public List<Comment> GetListAll(int id)
        {
            return _commentDal.GetListAll();
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
