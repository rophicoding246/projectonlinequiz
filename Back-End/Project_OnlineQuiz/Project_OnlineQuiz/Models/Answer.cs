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
    
    public partial class Answer
    {
        public string CodeAnswer { get; set; }
        public string Text { get; set; }
        public Nullable<bool> IsCorrect { get; set; }
        public string CodeQuestion { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
