using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class DbContext
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext()
            {

            }

            public DbSet<About> Abouts { get; set; }
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Comment> Comments { get; set; }
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Portfolio> Portfolios { get; set; }
          
        }
    }
}
