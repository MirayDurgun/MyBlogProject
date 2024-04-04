using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminCommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }

        public IActionResult CommentDelete(int id)
        {
            var commentvalue = cm.GetById(id);
            cm.TDelete(commentvalue);
            return RedirectToAction("Index", "AdminComment");

        }

        public IActionResult AdminCommentActive(int id, bool status)
        // İlgili commentun kimliği (id) ve yeni durumu (status) parametre olarak alındı.
        {
            var admincommentvalue = cm.GetById(id);
            // comment'in etkinlik durumunu, gelen 'status' parametresiyle günceller.
            admincommentvalue.Status = status;
            //status değişkeni, bu durumun yeni değerini taşır
            cm.TUpdate(admincommentvalue);

            return RedirectToAction("Index", "AdminComment");

        }
    }
}
