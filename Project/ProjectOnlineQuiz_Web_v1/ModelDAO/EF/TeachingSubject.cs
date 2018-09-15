namespace ModelDAO.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeachingSubject")]
    public partial class TeachingSubject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeachingSubject()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodeTeacher { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodeSubject { get; set; }

        public DateTime? DateJoined { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
