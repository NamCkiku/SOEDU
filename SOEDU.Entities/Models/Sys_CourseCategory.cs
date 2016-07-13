namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_CourseCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_CourseCategory()
        {
            Sys_CourseCategory1 = new HashSet<Sys_CourseCategory>();
        }

        [Key]
        [StringLength(50)]
        public string Category_ID { get; set; }

        [StringLength(50)]
        public string Course_ID { get; set; }

        [StringLength(500)]
        public string Category_Name { get; set; }

        [StringLength(250)]
        public string Title_Name { get; set; }

        [Column(TypeName = "image")]
        public byte[] IsIcon { get; set; }

        [StringLength(50)]
        public string Parent_ID { get; set; }

        public virtual Sys_Course Sys_Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_CourseCategory> Sys_CourseCategory1 { get; set; }

        public virtual Sys_CourseCategory Sys_CourseCategory2 { get; set; }
    }
}
