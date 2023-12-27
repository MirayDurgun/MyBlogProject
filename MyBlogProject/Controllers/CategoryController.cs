using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        [Authorize]
        public IActionResult Index()
        {
            var values = cm.GetList();
            //cm. içindeki bütün metotlara erişim sağlansın
        

            return View(values);
            //geriye valuesi döndür
        }
    }
}
