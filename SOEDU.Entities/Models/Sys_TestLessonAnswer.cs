namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_TestLessonAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_TestLessonAnswer()
        {
            Sys_TestLessonQuestion = new HashSet<Sys_TestLessonQuestion>();
        }

        [Key]
        [StringLength(50)]
        public string Answer_ID { get; set; }

        [StringLength(50)]
        public string Test_ID { get; set; }

        [StringLength(500)]
        public string Answer_Name { get; set; }

        public virtual Sys_Test Sys_Test { get; set; }

        public virtual Sys_TestLesson Sys_TestLesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_TestLessonQuestion> Sys_TestLessonQuestion { get; set; }
    }
}
