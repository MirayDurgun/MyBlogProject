using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProjectRepository : GenericRepository<Project>, IProjectDal
    {
        public List<Project> GetListWithPortfolio()
        {
           using (var c = new Context())
            {
                return c.Projects.Include(c => c.Portfolio).ToList();
            }
        }
    }
}
