namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Attach
    {
        [Key]
        [StringLength(50)]
        public string Attach_ID { get; set; }

        [StringLength(50)]
        public string Lesson_ID { get; set; }

        [StringLength(250)]
        public string File_Name { get; set; }

        [StringLength(250)]
        public string Des { get; set; }

        [Column(TypeName = "image")]
        public byte[] FileSource { get; set; }

        [StringLength(20)]
        public string FileSize { get; set; }

        public int? IsOrder { get; set; }

        public virtual Sys_Lesson Sys_Lesson { get; set; }
    }
}
