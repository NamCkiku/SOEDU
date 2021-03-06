﻿using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOEDU.Repository.Repositories
{
    public interface ILessonRepository: IRepository<Sys_Lesson>
    {

    }
    class LessonRepository : RepositoryBase<Sys_Lesson>, ILessonRepository
    {
        public LessonRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
