using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context()) //Contexti c 
            {
                return c.Blogs.Include(x => x.Category).ToList();
                //blog tablosundan her kaydı çekerken, blogun işilkili oluduğu categorydeki verileri de çeker
            }

        }

    }
}
