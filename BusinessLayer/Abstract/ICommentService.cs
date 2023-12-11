using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        //sadece yorum eklemeye ve listelemeye ihtiyacım var generic yapıya bağlamadım
        void CommentAdd(Comment comment);
        //void CategoryDelete(Category category);
        //void CategoryUpdate(Category category);
        List<Comment> GetList(int id);
        //Category GetCategoryById(int id);

        List<Comment> GetCommentListWithBlog();
    }
}
