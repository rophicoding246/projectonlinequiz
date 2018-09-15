namespace ModelDAO.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Test
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodeStudent { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodeClass { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CodeMixingExam { get; set; }

        public double? Scores { get; set; }

        public int? TimeWork { get; set; }

        public bool? Advent { get; set; }

        public virtual AttendClass AttendClass { get; set; }

        public virtual MixingExam MixingExam { get; set; }
    }
}
