using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface IStudentTestRepository : IRepository<Sys_StudentTest>
    {

    }
    class StudentTestRepository : RepositoryBase<Sys_StudentTest>, IStudentTestRepository
    {
        public StudentTestRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
