using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface IAttachRepository: IRepository<Sys_Attach>
    {

    }
    class AttachRepository : RepositoryBase<Sys_Attach>, IAttachRepository
    {
        public AttachRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
