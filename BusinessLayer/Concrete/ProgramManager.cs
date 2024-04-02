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
    public class ProgramManager : IProgramService
    {
        IProgramDal _programDal;
        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }

        public Program GetById(int id)
        {
            return _programDal.GetById(id);
        }

        public List<Program> GetList()
        {
            return _programDal.GetListAll().OrderByDescending(e => e.Id).ToList();
        }

        public void TAdd(Program t)
        {
            _programDal.Insert(t);
        }

        public void TDelete(Program t)
        {
           _programDal.Delete(t);
        }

        public void TUpdate(Program t)
        {
            _programDal.Update(t);
        }
    }
}
