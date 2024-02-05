using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ValidationResult = FluentValidation.Results.ValidationResult;


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

            var values = bm.GetList();
            return View(values);
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
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(b);

            if (results.IsValid)
            {
                b.BlogStatus = true;
                b.Category = cm.GetById(b.CategoryID);
                bm.TAdd(b);
                return RedirectToAction("Index", "AdminBlog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                // Hata durumunda, ViewBag.cv'yi set et
                ViewBag.cv = (from x in cm.GetList()
                              select new SelectListItem
                              {
                                  Text = x.CategoryName,
                                  Value = x.CategoryID.ToString()
                              }).ToList();

                return View();
            }
        }



    }
}
