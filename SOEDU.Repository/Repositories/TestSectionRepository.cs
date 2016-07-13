using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;

namespace SOEDU.Repository.Repositories
{
    public interface ITestSectionRepository : IRepository<Sys_TestSection>
    {
    }

    internal class TestSectionRepository : RepositoryBase<Sys_TestSection>, ITestSectionRepository
    {
        public TestSectionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}