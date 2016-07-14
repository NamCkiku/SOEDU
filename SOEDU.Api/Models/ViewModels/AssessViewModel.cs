using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOEDU.Api.Models.ViewModels
{
    public class AssessViewModel
    {

        public string Assess_ID { get; set; }


        public string Course_ID { get; set; }

        public int? IsStar { get; set; }

        public string Description { get; set; }


        public DateTime? CreateDate { get; set; }

        public virtual CourseViewModel Sys_Course { get; set; }
    }
}