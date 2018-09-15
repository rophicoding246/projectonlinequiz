namespace ModelDAO.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttendClass")]
    public partial class AttendClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttendClass()
        {
            Tests = new HashSet<Test>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodeStudent { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodeClass { get; set; }

        public DateTime? DateJoined { get; set; }

        public virtual Class Class { get; set; }

        public virtual Student Student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test> Tests { get; set; }
    }
}
