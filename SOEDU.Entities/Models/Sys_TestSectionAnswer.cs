namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_TestSectionAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_TestSectionAnswer()
        {
            Sys_TestSectionQuestion = new HashSet<Sys_TestSectionQuestion>();
        }

        [Key]
        [StringLength(50)]
        public string Answer_ID { get; set; }

        [StringLength(50)]
        public string TestSection_ID { get; set; }

        [StringLength(250)]
        public string Answer_Name { get; set; }

        public virtual Sys_TestSection Sys_TestSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_TestSectionQuestion> Sys_TestSectionQuestion { get; set; }
    }
}
