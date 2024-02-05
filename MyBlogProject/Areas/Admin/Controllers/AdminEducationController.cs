using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminEducationController : Controller
    {
        EducationManager em = new EducationManager(new EfEducationRepository());
        public IActionResult Index()
        {
            return View();
        }
    }
}
