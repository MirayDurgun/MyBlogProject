using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;
        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public List<Project> GetProjectById(int id)
        {
            return _projectDal.GetListAll(x => x.ProjectId == id);
            //idye eşit olan değerleri ister
        }
        public Project GetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public List<Project> GetList()
        {
            return _projectDal.GetListAll().OrderByDescending(e => e.ProjectId).ToList();
        }

        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            _projectDal.Delete(t);
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);
        }

        public List<Project> GetLast8Project()
        {
            return _projectDal.GetListAll().Take(8).OrderByDescending(e => e.ProjectId).ToList();
            //sadece idsi yakın olan ilk 8 öğeyi seçer.


            //project single son projelerin hepsini yansıtmak yerine sadece 
            //8 tane getirmesini sağladım
        }

        public List<Project> GetLast4Project()
        {
            return _projectDal.GetListAll().Take(4).OrderByDescending(e => e.ProjectId).ToList();
        }
    }
}
