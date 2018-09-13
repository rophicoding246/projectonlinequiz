namespace DAOModel.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MixingExam")]
    public partial class MixingExam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MixingExam()
        {
            MixingExamDetails = new HashSet<MixingExamDetail>();
            Tests = new HashSet<Test>();
        }

        [Key]
        [StringLength(20)]
        public string CodeMixingExam { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string CodeExam { get; set; }

        public virtual Exam Exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MixingExamDetail> MixingExamDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test> Tests { get; set; }
    }
}
