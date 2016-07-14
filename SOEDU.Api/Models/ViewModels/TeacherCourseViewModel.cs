using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOEDU.Api.Models.ViewModels
{
    public class TeacherCourseViewModel
    {
        
        public string User_ID { get; set; }

        
        public string Course_ID { get; set; }

        public bool? IsSupper { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsStatus { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual CourseViewModel Sys_Course { get; set; }

        public virtual UsersViewModel Sys_Users { get; set; }
    }
}