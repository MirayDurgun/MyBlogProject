using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {    
        public void Delete(T t)
        {
          using var c=new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList(); //burada kullanılacak entity olmadığından dışardan alabilmek için set yöntemi kullandık
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
            //idyi arar
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
			using var c = new Context();
			return c.Set<T>().Where(filter).ToList();
            //filterdan gelen değere göre listeler
		}

		public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
	}
}
