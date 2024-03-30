using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Project
{
	public class FooterProject : ViewComponent
	{
		
		ProjectManager cm = new ProjectManager(new EfProjectRepository());
		public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetLast4Project();
			return View(values);
		}
	}
}
