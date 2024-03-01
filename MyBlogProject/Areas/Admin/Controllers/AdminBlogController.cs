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

        public IActionResult Index(string category)
        {
            var blogs = bm.GetList();
            foreach (var blog in blogs)
            {
                // Her bir blogun kategorisini, CategoryManager sınıfından kategori ID'sine göre alır.
                blog.Category = cm.GetById(blog.CategoryID);
            }
            if (!string.IsNullOrEmpty(category))
            {
                // Blogları, belirtilen kategoriye göre filtreler ve bir listeye dönüştürür
                blogs = blogs.Where(b => b.Category.CategoryName == category).ToList();
            }
            ViewBag.Category = category; // // Seçilen kategoriyi ViewBag'e atar.
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

        public IActionResult AdminBlogDelete(int id)
        {
            var adminblogvalue = bm.GetById(id);

            bm.TDelete(adminblogvalue);
            return RedirectToAction("Index", "AdminBlog");

        }

        public IActionResult AdminBlogActive(int id, bool status)
        // İlgili blogun kimliği (id) ve yeni durumu (status) parametre olarak alındı.
        {
            var adminblogvalue = bm.GetById(id);
            // Blogun etkinlik durumunu, gelen 'status' parametresiyle günceller.
            adminblogvalue.BlogStatus = status;
            //status değişkeni, bu durumun yeni değerini taşır
            bm.TUpdate(adminblogvalue);

            return RedirectToAction("Index", "AdminBlog");

        }

        [HttpGet]
        public IActionResult AdminBlogUpdate(int id)
        {
            var adminblogvalue = bm.GetById(id);
            return View(adminblogvalue);
        }

        [HttpPost]
        public IActionResult AdminBlogUpdate(Blog b)
        {
            var adminblogvalue = bm.GetById(b.BlogID);
            b.BlogStatus = true;
            bm.TUpdate(b);
            return RedirectToAction("Index", "AdminProject");
        }
    }
}
