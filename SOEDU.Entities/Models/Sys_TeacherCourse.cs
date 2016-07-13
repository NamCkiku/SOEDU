namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_TeacherCourse
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string User_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Course_ID { get; set; }

        public bool? IsSupper { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsStatus { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        public virtual Sys_Course Sys_Course { get; set; }

        public virtual Sys_Users Sys_Users { get; set; }
    }
}
