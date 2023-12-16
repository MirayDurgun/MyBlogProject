using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Certificate
{
	public class Certificate : ViewComponent
	{
        CertificateManager cm = new CertificateManager(new EfCertificateRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
