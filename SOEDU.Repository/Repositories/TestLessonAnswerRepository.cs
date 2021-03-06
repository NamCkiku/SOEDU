﻿using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ITestLessonAnswerRepository : IRepository<Sys_TestLessonAnswer>
    {

    }
    class TestLessonAnswerRepository : RepositoryBase<Sys_TestLessonAnswer>, ITestLessonAnswerRepository
    {
        public TestLessonAnswerRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
