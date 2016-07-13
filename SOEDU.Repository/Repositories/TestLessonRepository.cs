using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ITestLessonRepository : IRepository<Sys_TestLesson>
    {

    }
    class TestLessonRepository : RepositoryBase<Sys_TestLesson>, ITestLessonRepository
    {
        public TestLessonRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
