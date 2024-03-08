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
    public class ParentCommentManager : IParentCommentService
    {
        IParentCommentDal _parentCommentDal;
        public ParentCommentManager(IParentCommentDal parentCommentDal)
        {
            _parentCommentDal = parentCommentDal;
        }
        public void ParentCommentAdd(ParentComment parentComment)
        {
            _parentCommentDal.Insert(parentComment);
        }

        public List<ParentComment> GetParentCommentListWithComment()
        {
            return _parentCommentDal.GetListWithComment();
        }

        public List<ParentComment> GetList(int id)
        {
            return _parentCommentDal.GetListAll();
        }
    }
}
