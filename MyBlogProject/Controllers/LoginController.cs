using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogProject.Models;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.email, p.password, false, true);
                // isPersistent: false - Oturumun kalıcı olmayacağını belirtir. Tarayıcı kapandığında oturum sona erecektir.
                // lockoutOnFailure: false - Başarısız giriş denemelerinde hesabın kilitlenmeyeceğini belirtir.
                // Giriş işlemi başarılı mı kontrol ediliyor
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin", new { area = "Admin" });
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
