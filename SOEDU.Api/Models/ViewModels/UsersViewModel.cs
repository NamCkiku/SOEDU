using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOEDU.Api.Models.ViewModels
{
    public class UsersViewModel
    {

        public string User_ID { get; set; }


        public string User_Name { get; set; }


        public string IsPassword { get; set; }

        public string IsName { get; set; }

        public bool? IsSex { get; set; }


        public string IsAdds { get; set; }


        public string IsEmail { get; set; }


        public string IsMobile { get; set; }

        public string IsDes { get; set; }

        public byte[] IsFoto { get; set; }

        public bool? IsLocked { get; set; }


        public string IsLevel { get; set; }


        public DateTime? CreateDate { get; set; }


        public virtual ICollection<StudentCourseViewModel> Sys_StudentCourse { get; set; }


        public virtual ICollection<StudentTestViewModel> Sys_StudentTest { get; set; }

        public virtual ICollection<StudentTestSectionViewModel> Sys_StudentTestSection { get; set; }


        public virtual ICollection<TargetViewModel> Sys_Target { get; set; }


        public virtual ICollection<TeacherCourseViewModel> Sys_TeacherCourse { get; set; }
    }
}