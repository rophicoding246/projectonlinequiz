namespace DAOModel.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MixingExamDetail
    {
        [Key]
        [StringLength(20)]
        public string CodeMixingExamDetail { get; set; }

        public int? Num { get; set; }

        [StringLength(20)]
        public string CodeMixingExam { get; set; }

        [StringLength(20)]
        public string CodeExamDetail { get; set; }

        public virtual ExamDetail ExamDetail { get; set; }

        public virtual MixingExam MixingExam { get; set; }
    }
}
