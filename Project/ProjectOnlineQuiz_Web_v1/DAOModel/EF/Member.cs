namespace DAOModel.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member
    {
        [Key]
        [StringLength(20)]
        public string CodeMember { get; set; }

        [StringLength(50)]
        public string Fullname { get; set; }

        [StringLength(30)]
        public string Gender { get; set; }

        public DateTime? DoB { get; set; }

        public int? Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public virtual Account Account { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Student Student { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
