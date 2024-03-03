using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult CategoryAdd(Category c)
        {
            cm.TAdd(c);
            return RedirectToAction("Index", "AdminCategory");


        }

        public IActionResult CategoryDelete(int id)
        {
            var categoryvalue = cm.GetById(id);

            cm.TDelete(categoryvalue);
            return RedirectToAction("Index", "AdminCategory");

        }

        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            var categoryvalue = cm.GetById(id);
            return View(categoryvalue);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category c)
        {
            
            var categoryvalue = cm.GetById(c.CategoryID);
            cm.TUpdate(c);
            return RedirectToAction("Index", "AdminCategory");
            
        }
    }
}
