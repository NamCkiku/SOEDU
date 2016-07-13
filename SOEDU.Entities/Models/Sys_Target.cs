namespace SOEDU.Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Target
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Target()
        {
            Sys_Target1 = new HashSet<Sys_Target>();
        }

        [Key]
        [StringLength(50)]
        public string Target_ID { get; set; }

        [StringLength(50)]
        public string Course_ID { get; set; }

        [StringLength(50)]
        public string User_ID { get; set; }

        [StringLength(50)]
        public string Parent_ID { get; set; }

        public int? IsStar { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        public int? IsOrder { get; set; }

        public virtual Sys_Course Sys_Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Target> Sys_Target1 { get; set; }

        public virtual Sys_Target Sys_Target2 { get; set; }

        public virtual Sys_Users Sys_Users { get; set; }
    }
}
