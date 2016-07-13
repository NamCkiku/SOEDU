namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Assess
    {
        [Key]
        [StringLength(50)]
        public string Assess_ID { get; set; }

        [StringLength(50)]
        public string Course_ID { get; set; }

        public int? IsStar { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        public virtual Sys_Course Sys_Course { get; set; }
    }
}
