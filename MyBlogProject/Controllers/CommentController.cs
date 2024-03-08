using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        ParentCommentManager pcm = new ParentCommentManager(new EfParentCommentRepository());
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

        [HttpGet]
        public IActionResult ParentAddComment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ParentAddComment(ParentComment parentComment)
        {
            pcm.ParentCommentAdd(parentComment);
            return RedirectToAction("BlogSingle", "Blog");
        }
    }
}
