using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyBlogProject.Areas.Admin.ViewComponents
{
    public class BlogCountWidgets : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke(int id)
        {


            //BLOG
            int BlogCount = c.Blogs.Count();
            // belirli bir kriteri sağlayan blog sayısını alalım (örneğin, aktif bloglar)
            int activeBlogCount = c.Blogs.Count(b => b.BlogStatus == true);
            int passiveBlogCount = c.Blogs.Count(b => b.BlogStatus == false);
            // IsActive alanına göre filtreleme yapılabilir
            // Yüzdeliği hesaplayalım
            double percentage = (double)activeBlogCount / BlogCount * 100;
            // ViewBag'e yüzdeliği atayalım
            ViewBag.Percentage = percentage;
            //aktif blog sayısı
            ViewBag.ActiveBlogCount = activeBlogCount;
            //pasif blog sayısı
            ViewBag.PassiveBlogCount = passiveBlogCount;
            //toplam blog sayısı
            ViewBag.BlogCount = c.Blogs.Count();


            //PROJE
            int ProjectCount = c.Projects.Count();
            int activeProjectCount = c.Projects.Count(b => b.ProjectStatus == true);
            int passiveProjectCount = c.Projects.Count(b => b.ProjectStatus == false);
            double percentage2 = (double)activeProjectCount / ProjectCount * 100;
            ViewBag.Percentage2 = percentage2;
            ViewBag.ActiveProjectCount = activeProjectCount;
            ViewBag.PassiveProjectCount = passiveProjectCount;
            ViewBag.ProjectCount = c.Projects.Count();


            //SERTİFİKA
            //toplam sertifika eğitim süresi sayısı
            ViewBag.CertificateCount = c.Certificates.Count();
            double topCertificateHours = 0;
            var certificates = c.Certificates.ToList();
            foreach (var item in certificates)
            {
                if (item.EducationDurationHours != null)
                {
                    double CertificatesHours = Convert.ToDouble(item.EducationDurationHours);
                    topCertificateHours += CertificatesHours;
                }
            }
            ViewBag.TopCertificateHours = topCertificateHours;

            //YETKİNLİK
            var count = c.Skills.Count();
            ViewBag.SkillCount=count;
            double topSkillScore = 0;
            var skills = c.Skills.ToList();
            foreach (var item in skills)
            {
                if (item.SkillScore != null)
                {
                    double skillstop = Convert.ToDouble(item.SkillScore);
                    topSkillScore += skillstop;
                }
            }
            //ortalama skor
            double topScore = topSkillScore / count;
            ViewBag.TopScore = topScore;


            return View();
        }
    }
}
