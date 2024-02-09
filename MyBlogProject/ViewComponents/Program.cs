using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Program
{
	public class Program : ViewComponent
	{
        ProgramManager pm = new ProgramManager(new EfProgramRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
