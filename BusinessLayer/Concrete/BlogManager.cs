using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory().OrderByDescending(e => e.BlogCreateDate).ToList();

        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
            //idye eşit olan değerleri ister
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll().OrderByDescending(blog => blog.BlogCreateDate).ToList();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public List<Blog> GetLast4Blog()
        {
            return _blogDal.GetListAll()
                    .OrderByDescending(blog => blog.BlogCreateDate)
                    .Take(4)
                    .ToList();
            //sadece tarihi yakın olan ilk 4 öğeyi seçer.


            //footerda son postların hepsini yansıtmak yerine sadece 
            //4 tane getirmesini sağladım
        }

        public List<Blog> GetLast5Blog()
        {
            return _blogDal.GetListAll()
                  .OrderByDescending(blog => blog.BlogCreateDate)
                  .Take(5)
                  .ToList();
            //sadece tarihi yakın olan ilk 5 öğeyi seçer.


            //blog single son postların hepsini yansıtmak yerine sadece 
            //5 tane getirmesini sağladım
        }
    }

}
