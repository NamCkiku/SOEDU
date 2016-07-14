using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOEDU.Api.Models.ViewModels
{
    public class TargetViewModel
    {

        public string Target_ID { get; set; }


        public string Course_ID { get; set; }


        public string User_ID { get; set; }

        public string Parent_ID { get; set; }

        public int? IsStar { get; set; }

        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? IsOrder { get; set; }

        public virtual CourseViewModel Sys_Course { get; set; }

        public virtual ICollection<TargetViewModel> Sys_Target1 { get; set; }

        public virtual TargetViewModel Sys_Target2 { get; set; }

        public virtual UsersViewModel Sys_Users { get; set; }
    }
}