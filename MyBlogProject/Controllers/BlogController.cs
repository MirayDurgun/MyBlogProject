using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MyBlogProject.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogSingle(int id)
        {
            var values = bm.GetBlogById(id);
            //idye göre detayları getirecek
            ViewBag.BlogID = id; //yorum için

            var comments = cm.GetList().Where(c => c.BlogID == id).ToList();
            // Yorum sayısını alıyoruz
            ViewBag.CommentCount = comments.Count;
            return View(values);

        }
    }
}
