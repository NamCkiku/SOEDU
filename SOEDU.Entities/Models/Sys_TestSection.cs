namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_TestSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_TestSection()
        {
            Sys_StudentTestSection = new HashSet<Sys_StudentTestSection>();
            Sys_TestSectionAnswer = new HashSet<Sys_TestSectionAnswer>();
        }

        [Key]
        [StringLength(50)]
        public string TestSection_ID { get; set; }

        [StringLength(50)]
        public string Section_ID { get; set; }

        [StringLength(50)]
        public string IsSetTime { get; set; }

        [StringLength(500)]
        public string Test_Name { get; set; }

        public virtual Sys_Section Sys_Section { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_StudentTestSection> Sys_StudentTestSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_TestSectionAnswer> Sys_TestSectionAnswer { get; set; }
    }
}
