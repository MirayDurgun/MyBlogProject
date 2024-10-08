﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
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
            if (!ModelState.IsValid)
            {
                return View(c);
            }


                cm.TAdd(c);
                return RedirectToAction("Index", "AdminPortfolio");
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
            if (!ModelState.IsValid)
            {
                return View(c);
            }

            var certificatevalue = cm.GetById(c.CertificateId);
            cm.TUpdate(c);
            return RedirectToAction("Index", "AdminPortfolio");
        }
    }
}
