using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Portolio
{
    public class AdminProfileForProject : ViewComponent
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
