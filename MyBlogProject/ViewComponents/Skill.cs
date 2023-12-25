using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Skill
{
	public class Skill : ViewComponent
	{
        SkillManager sm = new SkillManager(new EfSkillRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = sm.GetList();
            return View(values);
        }
    }
}
