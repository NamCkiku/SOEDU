namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Test()
        {
            Sys_StudentTest = new HashSet<Sys_StudentTest>();
            Sys_TestLessonAnswer = new HashSet<Sys_TestLessonAnswer>();
        }

        [Key]
        [StringLength(50)]
        public string Test_ID { get; set; }

        [StringLength(50)]
        public string Lesson_ID { get; set; }

        [StringLength(50)]
        public string Test_Name { get; set; }

        [StringLength(50)]
        public string IsSetTime { get; set; }

        public virtual Sys_Lesson Sys_Lesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_StudentTest> Sys_StudentTest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_TestLessonAnswer> Sys_TestLessonAnswer { get; set; }
    }
}
