using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminSkillController : Controller
    {
        SkillManager sm = new SkillManager(new EfSkillRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SkillAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult SkillAdd(Skill s)
        {
            sm.TAdd(s);
            return RedirectToAction("Index", "AdminPortfolio");
        }

        public IActionResult SkillDelete(int id)
        {
            var projectvalue = sm.GetById(id);

            sm.TDelete(projectvalue);
            return RedirectToAction("Index", "AdminProject");

        }

        [HttpGet]
        public IActionResult SkillUpdate(int id)
        {
            var skillvalue = sm.GetById(id);
            return View(skillvalue);
        }

        [HttpPost]
        public IActionResult SkillUpdate(Skill s)
        {
            var skillvalue = sm.GetById(s.SkillId);
            sm.TUpdate(s);
            return RedirectToAction("Index", "AdminPortfolio");
        }

    }
}
