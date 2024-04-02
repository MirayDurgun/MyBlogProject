using BusinessLayer.Concrete;
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
            if (!ModelState.IsValid)
            {
                return View(j);
            }

            jm.TAdd(j);
            return RedirectToAction("Index", "AdminPortfolio");

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
            if (!ModelState.IsValid)
            {
                return View(j);
            }

            var jobvalue = jm.GetById(j.JobId);
            jm.TUpdate(j);
            return RedirectToAction("Index", "AdminPortfolio");

        }
    }
}
