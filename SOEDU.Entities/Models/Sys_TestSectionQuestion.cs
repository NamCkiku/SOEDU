namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_TestSectionQuestion
    {
        [Key]
        [StringLength(50)]
        public string Question_ID { get; set; }

        [StringLength(50)]
        public string Answer_ID { get; set; }

        [StringLength(500)]
        public string Question_Name { get; set; }

        public bool? IsSupper { get; set; }

        public bool? IsOK { get; set; }

        public virtual Sys_TestSectionAnswer Sys_TestSectionAnswer { get; set; }
    }
}
