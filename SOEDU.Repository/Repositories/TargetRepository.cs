using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ITargetRepository
    {

    }
    class TargetRepository : RepositoryBase<Sys_Target>, ITargetRepository
    {
        public TargetRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
