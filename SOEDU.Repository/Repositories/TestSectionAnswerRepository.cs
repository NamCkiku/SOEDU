using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ITestSectionAnswerRepository
    {

    }
    class TestSectionAnswerRepository : RepositoryBase<Sys_TestSectionAnswer>, ITestSectionAnswerRepository
    {
        public TestSectionAnswerRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
