﻿using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ITestSectionQuestionRepository : IRepository<Sys_TestSectionQuestion>
    {

    }
    class TestSectionQuestionRepository : RepositoryBase<Sys_TestSectionQuestion>, ITestSectionQuestionRepository
    {
        public TestSectionQuestionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
