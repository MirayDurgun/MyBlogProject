using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.Status = false;
            cm.TAdd(comment);
            return RedirectToAction("BlogSingle", "Blog", new { id = comment.BlogID });
        }
    }
}
