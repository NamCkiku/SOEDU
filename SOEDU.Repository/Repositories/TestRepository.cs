using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ITestRepository : IRepository<Sys_Test>
    {

    }
    class TestRepository : RepositoryBase<Sys_Test>, ITestRepository
    {
        public TestRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
