using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IGenericService<T>
	{
		//CRUD
		void TAdd(T t);
		void TDelete(T t);
		void TUpdate(T t);
		List<T> GetList();
		T GetById(int id);
	}
}
