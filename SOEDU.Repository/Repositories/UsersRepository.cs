using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface IUsersRepository : IRepository<Sys_Users>
    {
        Sys_Users GetSingleByUsername(string username);
    }
    class UsersRepository : RepositoryBase<Sys_Users>, IUsersRepository
    {
        public UsersRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public Sys_Users GetSingleByUsername(string username)
        {
            return DbContext.Sys_Users.FirstOrDefault(x => x.User_Name == username);
        }
    }
}
