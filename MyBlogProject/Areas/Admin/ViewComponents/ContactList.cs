using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyBlogProject.Areas.Admin.ViewComponents
{
    public class ContactList : ViewComponent
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetLast5Contact();
            return View(values);
        }

    }
}
