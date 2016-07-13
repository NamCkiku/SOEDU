using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface IAssessRepository : IRepository<Sys_Assess>
    {

    }
    class AssessRepository : RepositoryBase<Sys_Assess>, IAssessRepository
    {
        public AssessRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
