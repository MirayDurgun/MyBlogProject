﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminEducationController : Controller
    {
        EducationManager em = new EducationManager(new EfEducationRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EducationAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult EducationAdd(Education e)
        {

            //if (results.IsValid)
            //{
                em.TAdd(e);
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

        public IActionResult EducationDelete(int id)
        {
            var educationvalue = em.GetById(id);

            em.TDelete(educationvalue);
            return RedirectToAction("Index", "AdminPortfolio");

        }

        [HttpGet]
        public IActionResult EducationUpdate(int id)
        {
            var educationvalue = em.GetById(id);
            return View(educationvalue);
        }

        [HttpPost]
        public IActionResult EducationUpdate(Education e)
        {
            //EducationValidator jv = new EducationValidator();
            //ValidationResult results = jv.Validate(j);

            //if (results.IsValid)
            //{
                var educationvalue = em.GetById(e.EducationId);
                em.TUpdate(e);
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
