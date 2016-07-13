using SOEDU.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SOEDUEntity Init();
    }
}
