using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOEDU.Api.Models.ViewModels
{
    public class CourseViewModel
    {
        public string Course_ID { get; set; }

        public string Course_Name { get; set; }


        public byte[] Avatar { get; set; }


        public string Video { get; set; }


        public string Description { get; set; }

        public double? IsPrice { get; set; }

        public double? IsPriceSale { get; set; }

        public int? ViewCount { get; set; }


        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }

        public int? IsOrder { get; set; }

        public virtual ICollection<AssessViewModel> Sys_Assess { get; set; }


        public virtual ICollection<CourseCategoryViewModel> Sys_CourseCategory { get; set; }


        public virtual ICollection<SectionViewModel> Sys_Section { get; set; }

        public virtual ICollection<StudentCourseViewModel> Sys_StudentCourse { get; set; }


        public virtual ICollection<TargetViewModel> Sys_Target { get; set; }


        public virtual ICollection<TeacherCourseViewModel> Sys_TeacherCourse { get; set; }
    }
}