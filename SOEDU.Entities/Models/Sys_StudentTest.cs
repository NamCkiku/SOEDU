namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_StudentTest
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string User_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Test_ID { get; set; }

        public DateTime? IsDate { get; set; }

        [StringLength(50)]
        public string IsGetTime { get; set; }

        public virtual Sys_Test Sys_Test { get; set; }

        public virtual Sys_Users Sys_Users { get; set; }

        public virtual Sys_TestLesson Sys_TestLesson { get; set; }
    }
}
