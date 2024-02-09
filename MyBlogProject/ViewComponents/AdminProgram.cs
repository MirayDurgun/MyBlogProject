using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents
{
    public class AdminProgram : ViewComponent
    {
        ProgramManager pm = new ProgramManager(new EfProgramRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
