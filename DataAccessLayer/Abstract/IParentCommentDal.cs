using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IParentCommentDal : IGenericDal<ParentComment>
    {
        List<ParentComment> GetListWithComment();
        //Commenti Blogla beraber getirecek
    }
}
