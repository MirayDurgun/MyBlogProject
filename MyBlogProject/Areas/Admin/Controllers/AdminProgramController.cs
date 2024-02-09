using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProgramController : Controller
    {
        ProgramManager pm = new ProgramManager(new EfProgramRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProgramAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProgramAdd(EntityLayer.Concrete.Program p)
        {

            //if (results.IsValid)
            //{
            pm.TAdd(p);
            return RedirectToAction("Index", "AdminPortfolio");
            //}
            //else
            //{
            //    foreach (var itpm in results.Errors)
            //    {
            //        ModelState.AddModelError(itpm.PropertyName, itpm.ErrorMessage);
            //    }
            //    return View();
            //}
        }

        public IActionResult ProgramDelete(int id)
        {
            var programvalue = pm.GetById(id);

            pm.TDelete(programvalue);
            return RedirectToAction("Index", "AdminPortfolio");

        }

    }
}
