using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
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
            if (!ModelState.IsValid)
            {
                return View(t);
            }

            tm.TAdd(t);
            return RedirectToAction("Index", "AdminPortfolio");
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
            if (!ModelState.IsValid)
            {
                return View(t);
            }

            var educationvalue = tm.GetById(t.TestimonialId);
            tm.TUpdate(t);
            return RedirectToAction("Index", "AdminPortfolio");
        }
    }
}
