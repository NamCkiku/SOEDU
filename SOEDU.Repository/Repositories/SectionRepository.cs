using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ISectionRepository
    {

    }
    class SectionRepository : RepositoryBase<Sys_Section>, ISectionRepository
    {
        public SectionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
