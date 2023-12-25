using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CorePortfolio.ViewComponents.Portfolio
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
