namespace ModelDAO.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            AttendClasses = new HashSet<AttendClass>();
            Exams = new HashSet<Exam>();
        }

        [Key]
        [StringLength(20)]
        public string CodeClass { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(20)]
        public string CodeSubject { get; set; }

        [StringLength(20)]
        public string CodeTeacher { get; set; }

        [StringLength(20)]
        public string CodeTerm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendClass> AttendClasses { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Term Term { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
