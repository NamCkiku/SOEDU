namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Lesson()
        {
            Sys_Attach = new HashSet<Sys_Attach>();
            Sys_Lesson1 = new HashSet<Sys_Lesson>();
            Sys_Test = new HashSet<Sys_Test>();
        }

        [Key]
        [StringLength(50)]
        public string Lesson_ID { get; set; }

        [StringLength(50)]
        public string Section_ID { get; set; }

        [StringLength(250)]
        public string Lesson_Name { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(500)]
        public string Video { get; set; }

        [StringLength(50)]
        public string ParentID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        public int? IsOrder { get; set; }

        public bool? IsStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Attach> Sys_Attach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Lesson> Sys_Lesson1 { get; set; }

        public virtual Sys_Lesson Sys_Lesson2 { get; set; }

        public virtual Sys_Section Sys_Section { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Test> Sys_Test { get; set; }
    }
}
