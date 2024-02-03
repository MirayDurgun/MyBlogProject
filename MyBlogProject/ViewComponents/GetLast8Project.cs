using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;


namespace MyBlogProject.ViewComponents.Project
{
    public class GetLast8Project : ViewComponent
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetLast8Project();
            return View(values);
        }
    }
}
