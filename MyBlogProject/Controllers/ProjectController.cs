﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyProjectProject.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());


        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProjectSingle()
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
