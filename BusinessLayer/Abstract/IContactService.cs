using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IContactService
	{
		//sadece eklemeye ihtiyaç olduğundan generic yapıya bağlamadım
		void ContactAdd(Contact contact);
	}
}
