using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminJobController : Controller
    {
        JobManager jm = new JobManager(new EfJobRepository());
        public IActionResult Index()
        {
            var values = jm.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult JobAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult JobAdd(Job j)
        {

            JobValidator jv = new JobValidator();
            ValidationResult results = jv.Validate(j);

            if (results.IsValid)
            {
                jm.TAdd(j);
                return RedirectToAction("Index", "AdminPortfolio");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult JobDelete(int id)
        {
            var jobvalue = jm.GetById(id);

            jm.TDelete(jobvalue);
            return RedirectToAction("Index", "AdminPortfolio");

        }

        [HttpGet]
        public IActionResult JobUpdate(int id)
        {
            var jobvalue = jm.GetById(id);
            return View(jobvalue);
        }

        [HttpPost]
        public IActionResult JobUpdate(Job j)
        {
            JobValidator jv = new JobValidator();
            ValidationResult results = jv.Validate(j);

            if (results.IsValid)
            {
                var jobvalue = jm.GetById(j.JobId);
                jm.TUpdate(j);
                return RedirectToAction("Index", "AdminPortfolio");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }
    }
}
