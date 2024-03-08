using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        //sadece yorum eklemeye ve listelemeye ihtiyacım var generic yapıya bağlamadım
        List<Comment> GetListAll(int id);
        Comment GetById(int id);
        List<Comment> GetCommentListWithBlog();
    }
}
