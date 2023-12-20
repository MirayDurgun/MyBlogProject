using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager (new EfBlogRepository ());

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogSingle(int id)
        {
            //idye göre detayları getirecek
            ViewBag.i = id; //yorum için
            var values = bm.GetById(id);
            return View(values);
        }
    }
}
