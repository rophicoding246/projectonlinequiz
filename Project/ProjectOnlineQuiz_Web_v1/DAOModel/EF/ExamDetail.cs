namespace DAOModel.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExamDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamDetail()
        {
            MixingExamDetails = new HashSet<MixingExamDetail>();
        }

        [Key]
        [StringLength(20)]
        public string CodeExamDetail { get; set; }

        public int? Num { get; set; }

        [StringLength(20)]
        public string CodeExam { get; set; }

        [StringLength(20)]
        public string CodeQuestion { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Question Question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MixingExamDetail> MixingExamDetails { get; set; }
    }
}
