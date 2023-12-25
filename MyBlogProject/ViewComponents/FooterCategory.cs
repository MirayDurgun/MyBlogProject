using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.ViewComponents.Category
{
	public class FooterCategory : ViewComponent
	{
		
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke(int id)
        //id parametresini kullanarak ilgili kategori veya içeriği getirme işlemi yapılabilir.
        {
            var values = cm.GetFooterCategory();
			return View(values);
		}
	}
}
