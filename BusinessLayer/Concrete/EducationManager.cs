using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;
        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public Education GetById(int id)
        {
          return _educationDal.GetById(id);
        }

        public List<Education> GetList()
        {
            return _educationDal.GetListAll().OrderByDescending(e => e.EducationStartDate).ToList();
        }

        public void TAdd(Education t)
        {
           _educationDal.Insert(t);
        }

        public void TDelete(Education t)
        {
           _educationDal.Delete(t);
        }

        public void TUpdate(Education t)
        {
           _educationDal.Update(t);
        }
    }
}
