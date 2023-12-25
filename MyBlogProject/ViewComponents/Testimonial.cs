using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Testimonial
{
	public class Testimonial : ViewComponent
	{
        TestimonialManager tm = new TestimonialManager(new EfTestimonialRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = tm.GetList();
            return View(values);
        }
    }
}
