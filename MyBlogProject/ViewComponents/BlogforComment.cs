using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Comment
{
    public class AboutforPortfolio : ViewComponent
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
