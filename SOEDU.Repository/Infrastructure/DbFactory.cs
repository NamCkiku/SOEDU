using SOEDU.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SOEDUEntity dbContext;

        public SOEDUEntity Init()
        {
            return dbContext ?? (dbContext = new SOEDUEntity());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
