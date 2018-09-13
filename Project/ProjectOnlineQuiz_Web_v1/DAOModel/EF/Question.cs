namespace DAOModel.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Answers = new HashSet<Answer>();
            ExamDetails = new HashSet<ExamDetail>();
        }

        [Key]
        [StringLength(20)]
        public string CodeQuestion { get; set; }

        [StringLength(1000)]
        public string Text { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public int? Type { get; set; }

        public int? Difficulty { get; set; }

        public int? NumOfIterations { get; set; }

        [StringLength(20)]
        public string CodeSubject { get; set; }

        [StringLength(20)]
        public string CodeTeacher { get; set; }

        [StringLength(20)]
        public string CodeGeneralQuestion { get; set; }

        [StringLength(20)]
        public string CodeChapter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }

        public virtual Chapter Chapter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamDetail> ExamDetails { get; set; }

        public virtual GeneralQuestion GeneralQuestion { get; set; }

        public virtual TeachingSubject TeachingSubject { get; set; }
    }
}
