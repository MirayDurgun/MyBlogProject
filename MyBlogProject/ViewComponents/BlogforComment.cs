using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Comment
{
    public class BlogforComment : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}
    