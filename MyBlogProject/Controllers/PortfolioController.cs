﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class PortfolioController : Controller
    {
        AdminManager adm = new AdminManager(new EfAdminRepositoy());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = adm.GetList();
            return View(values);
        }
    }
}
