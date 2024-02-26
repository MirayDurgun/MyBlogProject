using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Admin
{
    public class AdminUserHeader : ViewComponent
    {
        AdminManager adm = new AdminManager(new EfAdminRepositoy());
        public IViewComponentResult Invoke(int id)
        {
            var values = adm.GetList();
            return View(values);
        }
    }
}
