using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminEducationController : Controller
    {
        EducationManager em = new EducationManager(new EfEducationRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EducationAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult EducationAdd(Education e)
        {
            if (!ModelState.IsValid)
            {
                return View(e);
            }

            em.TAdd(e);
            return RedirectToAction("Index", "AdminPortfolio");
        }

        public IActionResult EducationDelete(int id)
        {
            var educationvalue = em.GetById(id);

            em.TDelete(educationvalue);
            return RedirectToAction("Index", "AdminPortfolio");

        }

        [HttpGet]
        public IActionResult EducationUpdate(int id)
        {
            var educationvalue = em.GetById(id);
            return View(educationvalue);
        }

        [HttpPost]
        public IActionResult EducationUpdate(Education e)
        {
            if (!ModelState.IsValid)
            {
                return View(e);
            }

            var educationvalue = em.GetById(e.EducationId);
            em.TUpdate(e);
            return RedirectToAction("Index", "AdminPortfolio");

        }
    }
}
