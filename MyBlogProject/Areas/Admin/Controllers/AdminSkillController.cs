﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminSkillController : Controller
    {
        SkillManager sm = new SkillManager(new EfSkillRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SkillAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult SkillAdd(Skill s)
        {

            //if (results.IsValid)
            //{
            sm.TAdd(s);
            return RedirectToAction("Index", "AdminPortfolio");
            //}
            //else
            //{
            //    foreach (var itsm in results.Errors)
            //    {
            //        ModelState.AddModelError(itsm.PropertyName, itsm.ErrorMessage);
            //    }
            //    return View();
            //}
        }

      
    }
}
