using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace MyBlogProject.ViewComponents
{
    public class AdminCertificate : ViewComponent
    {
        CertificateManager cm = new CertificateManager(new EfCertificateRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
