//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_OnlineQuiz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamDetail()
        {
            this.MixingExamDetails = new HashSet<MixingExamDetail>();
        }
    
        public string CodeExamDetail { get; set; }
        public Nullable<int> Num { get; set; }
        public string CodeExam { get; set; }
        public string CodeQuestion { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual Question Question { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MixingExamDetail> MixingExamDetails { get; set; }
    }
}
