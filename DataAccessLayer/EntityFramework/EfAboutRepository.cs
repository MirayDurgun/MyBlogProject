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
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
        public List<About> GetListWithPortfolio()
        {
            using (var c = new Context()) //Contexti c 
            {
                return c.Abouts.Include(x => x.Portfolio).ToList();
              
            }
        }
    }

}
