﻿using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface IStudentTestSectionRepository
    {

    }
    class StudentTestSectionRepository : RepositoryBase<Sys_StudentTestSection>, IStudentTestSectionRepository
    {
        public StudentTestSectionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
