﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());
        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ProjectAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult ProjectAdd(Project p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            p.ProjectStatus = true;
            pm.TAdd(p);
            return RedirectToAction("Index", "AdminProject");
        }

        public IActionResult ProjectDelete(int id)
        {
            var projectvalue = pm.GetById(id);

            pm.TDelete(projectvalue);
            return RedirectToAction("Index", "AdminProject");

        }

        [HttpGet]
        public IActionResult ProjectUpdate(int id)
        {
            var projectvalue = pm.GetById(id);
            return View(projectvalue);
        }

        [HttpPost]
        public IActionResult ProjectUpdate(Project p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            var projectvalue = pm.GetById(p.ProjectId);
            p.ProjectStatus = true;
            pm.TUpdate(p);
            return RedirectToAction("Index", "AdminProject");
        }

        public IActionResult AdminProjectActive(int id, bool status)
        // İlgili blogun kimliği (id) ve yeni durumu (status) parametre olarak alındı.
        {
            var adminblogvalue = pm.GetById(id);
            // Blogun etkinlik durumunu, gelen 'status' parametresiyle günceller.
            adminblogvalue.ProjectStatus = status;
            //status değişkeni, bu durumun yeni değerini taşır
            pm.TUpdate(adminblogvalue);

            return RedirectToAction("Index", "AdminProject");

        }

    }
}

