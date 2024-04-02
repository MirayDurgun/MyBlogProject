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
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            pm.TAdd(p);
            return RedirectToAction("Index", "AdminPortfolio");
        }

        public IActionResult ProgramDelete(int id)
        {
            var programvalue = pm.GetById(id);

            pm.TDelete(programvalue);
            return RedirectToAction("Index", "AdminPortfolio");

        }


        [HttpGet]
        public IActionResult ProgramUpdate(int id)
        {
            var programvalue = pm.GetById(id);
            return View(programvalue);
        }

        [HttpPost]
        public IActionResult ProgramUpdate(EntityLayer.Concrete.Program p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            var programvalue = pm.GetById(p.Id);
            pm.TUpdate(p);
            return RedirectToAction("Index", "AdminPortfolio");
        }
    }
}
