namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Course()
        {
            Sys_Assess = new HashSet<Sys_Assess>();
            Sys_CourseCategory = new HashSet<Sys_CourseCategory>();
            Sys_Section = new HashSet<Sys_Section>();
            Sys_StudentCourse = new HashSet<Sys_StudentCourse>();
            Sys_Target = new HashSet<Sys_Target>();
            Sys_TeacherCourse = new HashSet<Sys_TeacherCourse>();
        }

        [Key]
        [StringLength(50)]
        public string Course_ID { get; set; }

        [StringLength(250)]
        public string Course_Name { get; set; }

        [Column(TypeName = "image")]
        public byte[] Avatar { get; set; }

        [StringLength(500)]
        public string Video { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public double? IsPrice { get; set; }

        public double? IsPriceSale { get; set; }

        public int? ViewCount { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }

        public int? IsOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Assess> Sys_Assess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_CourseCategory> Sys_CourseCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Section> Sys_Section { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_StudentCourse> Sys_StudentCourse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Target> Sys_Target { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_TeacherCourse> Sys_TeacherCourse { get; set; }
    }
}
