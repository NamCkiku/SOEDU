using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface IStudentCourseRepository: IRepository<Sys_StudentCourse>
    {

    }
    class StudentCourseRepository : RepositoryBase<Sys_StudentCourse>, IStudentCourseRepository
    {
        public StudentCourseRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
