using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminTestimonialController : Controller
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TestimonialAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult TestimonialAdd(Testimonial t)
        {

            //if (results.IsValid)
            //{
            tm.TAdd(t);
            return RedirectToAction("Index", "AdminPortfolio");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //    return View();
            //}
        }

        public IActionResult TestimonialDelete(int id)
        {
            var educationvalue = tm.GetById(id);

            tm.TDelete(educationvalue);
            return RedirectToAction("Index", "AdminPortfolio");

        }

        [HttpGet]
        public IActionResult TestimonialUpdate(int id)
        {
            var educationvalue = tm.GetById(id);
            return View(educationvalue);
        }

        [HttpPost]
        public IActionResult TestimonialUpdate(Testimonial t)
        {
            //TestimonialValidator jv = new TestimonialValidator();
            //ValidationResult results = jv.Validate(j);

            //if (results.IsValid)
            //{
            var educationvalue = tm.GetById(t.TestimonialId);
            tm.TUpdate(t);
            return RedirectToAction("Index", "AdminPortfolio");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //    return View();
            //}

        }
    }
}
