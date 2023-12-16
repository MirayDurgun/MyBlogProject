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
    public class JobManager : IJobService
    {
        IJobDal _jobDal;
        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public Job GetById(int id)
        {
           return _jobDal.GetById(id);
        }

        public List<Job> GetList()
        {
            return _jobDal.GetListAll();
        }

        public void TAdd(Job t)
        {
            _jobDal.Insert(t);
        }

        public void TDelete(Job t)
        {
            _jobDal.Delete(t);
        }

        public void TUpdate(Job t)
        {
            _jobDal.Update(t);
        }
    }
}
