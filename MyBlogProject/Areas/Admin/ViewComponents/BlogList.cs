using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.ViewComponents
{
    public class BlogList : ViewComponent
    {
        BlogManager bm=new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
           var values= bm.GetLast5Blog();
            return View(values);
        }
    }
}

