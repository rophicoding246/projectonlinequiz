namespace DAOModel.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Answer
    {
        [Key]
        [StringLength(20)]
        public string CodeAnswer { get; set; }

        [StringLength(1000)]
        public string Text { get; set; }

        public bool? IsCorrect { get; set; }

        [StringLength(20)]
        public string CodeQuestion { get; set; }

        public virtual Question Question { get; set; }
    }
}
