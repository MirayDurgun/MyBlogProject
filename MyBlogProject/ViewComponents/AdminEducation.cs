using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents
{
    public class AdminEducation : ViewComponent
    {
        EducationManager em = new EducationManager(new EfEducationRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = em.GetList();
            return View(values);
        }
    }
}
