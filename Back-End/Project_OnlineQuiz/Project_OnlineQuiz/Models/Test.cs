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
    
    public partial class Test
    {
        public string CodeStudent { get; set; }
        public string CodeClass { get; set; }
        public string CodeMixingExam { get; set; }
        public Nullable<double> Scores { get; set; }
        public Nullable<int> TimeWork { get; set; }
        public Nullable<bool> Advent { get; set; }
    
        public virtual AttendClass AttendClass { get; set; }
        public virtual MixingExam MixingExam { get; set; }
    }
}
