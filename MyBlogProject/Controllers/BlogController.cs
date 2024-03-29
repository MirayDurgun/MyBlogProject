﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager (new EfBlogRepository ());


        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);


        }
        public IActionResult BlogSingle(int id)
        {
            //idye göre detayları getirecek
            ViewBag.BlogID = id; //yorum için
            var values = bm.GetBlogById(id);
            return View(values);
        }


    }
}
