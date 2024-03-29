using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogProject.Models;

namespace MyBlogProject.Controllers
{
    [AllowAnonymous]

    //mimarinin içine de dahil edebilirdik service ve manager açmak gibi ve identity'nin kendi create kütüphanesini kullanacağız

    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
            if (ModelState.IsValid) //eğer UserSignUpViewModel deki işlemler sağlandıysa
            {
                AppUser user = new AppUser()
                {
                    Email = p.mail,
                    UserName=p.userName,     
                    NameSurname = p.nameSurname
                };
                var result = await _userManager.CreateAsync(user, p.password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description); //açıklama değeri hata olarak gelsin
                    }
                }
            }
            return View(p);
        }
    }
}
