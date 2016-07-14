using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOEDU.Api.Models.ViewModels
{
    public class SectionViewModel
    {

        public string Section_ID { get; set; }


        public string Course_ID { get; set; }

        
        public string Section_Name { get; set; }


        public string Title { get; set; }

 
        public string Description { get; set; }


        public DateTime? CreateDate { get; set; }

        public int? IsOrder { get; set; }

        public bool? IsStatus { get; set; }

        public virtual CourseViewModel Sys_Course { get; set; }

        public virtual ICollection<LessonViewModel> Sys_Lesson { get; set; }

        public virtual ICollection<TestSectionViewModel> Sys_TestSection { get; set; }
    }
}