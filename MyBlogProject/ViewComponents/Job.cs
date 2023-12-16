using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Job
{
	public class Job : ViewComponent
	{
        JobManager jm = new JobManager(new EfJobRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = jm.GetList();
            return View(values);
        }
    }
}
