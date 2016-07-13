using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using SOEDU.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Service
{
    public interface ICourseService
    {
        Sys_Course Add(Sys_Course course);
        void Update(Sys_Course course);
        Sys_Course Delete(int id);
        IEnumerable<Sys_Course> GetAll();
        IEnumerable<Sys_Course> GetAll(string keyword);
        Sys_Course GetByID(int id);
        void SaveChanges();
    }
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        private IUnitOfWork _IUnitOfWork;
        public CourseService(ICourseRepository courseRepository, IUnitOfWork IUnitOfWork)
        {
            this._courseRepository = courseRepository;
            this._IUnitOfWork = IUnitOfWork;
        }
        public Sys_Course Add(Sys_Course course)
        {
            return _courseRepository.Add(course);
        }

        public Sys_Course Delete(int id)
        {
            return _courseRepository.Delete(id);
        }

        public IEnumerable<Sys_Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public IEnumerable<Sys_Course> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _courseRepository.GetMulti(x => x.Course_Name.Contains(keyword) || x.Description.Contains(keyword));
            else
                return _courseRepository.GetAll();

        }

        public Sys_Course GetByID(int id)
        {
            return _courseRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _IUnitOfWork.Commit();
        }

        public void Update(Sys_Course course)
        {
            _courseRepository.Update(course);
        }
    }
}
