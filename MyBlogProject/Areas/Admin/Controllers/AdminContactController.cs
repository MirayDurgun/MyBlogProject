using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
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
            var contactvalue = cm.GetById(id);
            cm.TDelete(contactvalue);
            return RedirectToAction("Index", "AdminContact");

        }
        public IActionResult ContactDetail(int id)
        {
            var contact = cm.GetById(id);
            return View(contact);
        }

        public IActionResult AdminContactActive(int id, bool status)
        // İlgili blogun kimliği (id) ve yeni durumu (status) parametre olarak alındı.
        {
            var contactvalue = cm.GetById(id);
            // Contactun etkinlik durumunu, gelen 'status' parametresiyle günceller.
            contactvalue.ContactStatus = status;
            //status değişkeni, bu durumun yeni değerini taşır
            cm.TUpdate(contactvalue);

            return RedirectToAction("Index", "AdminContact");

        }
    }
}
