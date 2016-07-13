using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ICourseCategoryRepository: IRepository<Sys_CourseCategory>
    {

    }
    public class CourseCategoryRepository : RepositoryBase<Sys_CourseCategory>, ICourseCategoryRepository
    {
        public CourseCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
