using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Reflection.Metadata;


namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            var blogs = bm.GetList();
            foreach (var blog in blogs)
            {
                blog.Category = cm.GetById(blog.CategoryID);
            }
            return View(blogs);
        }

        public IActionResult BlogDetail(int id)
        {
            var blog = bm.GetById(id);

            blog.Category = cm.GetById(blog.CategoryID); //kategori adını getirdik


            return View(blog);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;

            return View();

        }

        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {

            b.BlogStatus = true;
            bm.TAdd(b);
            return RedirectToAction("Index", "AdminBlog");

        }
    }
}
