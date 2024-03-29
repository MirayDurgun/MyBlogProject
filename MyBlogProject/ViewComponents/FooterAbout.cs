using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.About
{
	public class FooterAbout : ViewComponent
	{
		
		AdminManager abm = new AdminManager(new EfAdminRepositoy());
		public IViewComponentResult Invoke(int id)
        //id parametresini kullanarak ilgili kategori veya içeriği getirme işlemi yapılabilir.
        {
            var values = abm.GetFooterAbout();
			return View(values);
		}
	}
}
