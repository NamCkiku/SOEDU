﻿using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ITeacherCourseRepository : IRepository<Sys_TeacherCourse>
    {

    }
    class TeacherCourseRepository : RepositoryBase<Sys_TeacherCourse>, ITeacherCourseRepository
    {
        public TeacherCourseRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
