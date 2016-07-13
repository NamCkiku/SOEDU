namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Section()
        {
            Sys_Lesson = new HashSet<Sys_Lesson>();
            Sys_TestSection = new HashSet<Sys_TestSection>();
        }

        [Key]
        [StringLength(50)]
        public string Section_ID { get; set; }

        [StringLength(50)]
        public string Course_ID { get; set; }

        [StringLength(250)]
        public string Section_Name { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        public int? IsOrder { get; set; }

        public bool? IsStatus { get; set; }

        public virtual Sys_Course Sys_Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Lesson> Sys_Lesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_TestSection> Sys_TestSection { get; set; }
    }
}
