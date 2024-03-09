using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyBlogProject.Areas.Admin.ViewComponents
{
    public class ContactCount : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke(int id)
        {
            //yalnızca okunmamış mesajların sayısı
            int ContatCount = c.Contacts.Count();
            int passiveContactCount = c.Contacts.Count(b => b.ContactStatus == false);
            ViewBag.PassiveContactCount = passiveContactCount;
            return View();
        }
    }
}
