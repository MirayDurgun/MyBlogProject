using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Blog
{
	public class BlogLast5Post : ViewComponent
	{
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = bm.GetLast5Blog();
            return View(values);
        }
    }
}
