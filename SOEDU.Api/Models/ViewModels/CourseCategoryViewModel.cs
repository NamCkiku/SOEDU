using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOEDU.Api.Models.ViewModels
{
    public class CourseCategoryViewModel
    {

        public string Category_ID { get; set; }


        public string Course_ID { get; set; }


        public string Category_Name { get; set; }

        public string Title_Name { get; set; }

        public byte[] IsIcon { get; set; }


        public string Parent_ID { get; set; }

        public virtual CourseViewModel Sys_Course { get; set; }
    }
}