using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }

        public IActionResult ContactDelete(int id)
        {
            var contactnvalue = cm.GetById(id);
            cm.TDelete(contactnvalue);
            return RedirectToAction("Index", "AdminContact");

        }
        public IActionResult ContactDetail(int id)
        {
            var contact = cm.GetById(id);
            return View(contact);
        }
    }
}
