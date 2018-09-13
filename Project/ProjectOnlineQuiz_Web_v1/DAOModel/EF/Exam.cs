namespace DAOModel.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            ExamDetails = new HashSet<ExamDetail>();
            MixingExams = new HashSet<MixingExam>();
        }

        [Key]
        [StringLength(20)]
        public string CodeExam { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? NumOfQuestions { get; set; }

        public int? NumOfMixings { get; set; }

        public int? Duration { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(20)]
        public string CodeClass { get; set; }

        public virtual Class Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamDetail> ExamDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MixingExam> MixingExams { get; set; }
    }
}
