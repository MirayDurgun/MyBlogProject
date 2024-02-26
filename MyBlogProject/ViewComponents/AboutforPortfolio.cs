using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Portolio
{
    public class AboutforPortfolio : ViewComponent
    {
        AdminManager pm = new AdminManager(new EfAdminRepositoy());
        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
