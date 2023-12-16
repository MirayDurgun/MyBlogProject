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
    public class CertificateManager : ICertificateService
    {
        ICertificateDal _certificateDal;
        public CertificateManager(ICertificateDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public Certificate GetById(int id)
        {
            return _certificateDal.GetById(id);
        }

        public List<Certificate> GetList()
        {
           return _certificateDal.GetListAll();
        }

        public void TAdd(Certificate t)
        {
            _certificateDal.Insert(t);
        }

        public void TDelete(Certificate t)
        {
            _certificateDal.Delete(t);
        }

        public void TUpdate(Certificate t)
        {
            _certificateDal.Update(t);
        }
    }
}
