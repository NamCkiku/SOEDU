namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Users()
        {
            Sys_StudentCourse = new HashSet<Sys_StudentCourse>();
            Sys_StudentTest = new HashSet<Sys_StudentTest>();
            Sys_StudentTestSection = new HashSet<Sys_StudentTestSection>();
            Sys_Target = new HashSet<Sys_Target>();
            Sys_TeacherCourse = new HashSet<Sys_TeacherCourse>();
        }

        [Key]
        [StringLength(50)]
        public string User_ID { get; set; }

        [StringLength(50)]
        public string User_Name { get; set; }

        [StringLength(100)]
        public string IsPassword { get; set; }

        [StringLength(50)]
        public string IsName { get; set; }

        public bool? IsSex { get; set; }

        [StringLength(250)]
        public string IsAdds { get; set; }

        [StringLength(50)]
        public string IsEmail { get; set; }

        [StringLength(50)]
        public string IsMobile { get; set; }

        [StringLength(500)]
        public string IsDes { get; set; }

        [Column(TypeName = "image")]
        public byte[] IsFoto { get; set; }

        public bool? IsLocked { get; set; }

        [StringLength(250)]
        public string IsLevel { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_StudentCourse> Sys_StudentCourse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_StudentTest> Sys_StudentTest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_StudentTestSection> Sys_StudentTestSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Target> Sys_Target { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_TeacherCourse> Sys_TeacherCourse { get; set; }
    }
}
