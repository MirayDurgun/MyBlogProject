using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Education
{
	public class Education : ViewComponent
	{
        EducationManager em = new EducationManager(new EfEducationRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = em.GetList();
            return View(values);
        }
    }
}
