using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents
{
    public class AdminTestimonial : ViewComponent
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = tm.GetList();
            return View(values);
        }
    }
}
