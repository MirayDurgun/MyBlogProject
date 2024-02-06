using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCertificateController : Controller
    {
        CertificateManager cm = new CertificateManager(new EfCertificateRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CertificateAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult CertificateAdd(Certificate c)
        {

            //if (results.IsValid)
            //{
            cm.TAdd(c);
            return RedirectToAction("Index", "AdminPortfolio");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //    return View();
            //}
        }

        public IActionResult CertificateDelete(int id)
        {
            var certificatevalue = cm.GetById(id);

            cm.TDelete(certificatevalue);
            return RedirectToAction("Index", "AdminPortfolio");

        }

        [HttpGet]
        public IActionResult CertificateUpdate(int id)
        {
            var certificatevalue = cm.GetById(id);
            return View(certificatevalue);
        }

        [HttpPost]
        public IActionResult CertificateUpdate(Certificate c)
        {
            //CertificateValidator jv = new CertificateValidator();
            //ValidationResult results = jv.Validate(j);

            //if (results.IsValid)
            //{
            var certificatevalue = cm.GetById(c.CertificateId);
            cm.TUpdate(c);
            return RedirectToAction("Index", "AdminPortfolio");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //    return View();
            //}

        }
    }
}
