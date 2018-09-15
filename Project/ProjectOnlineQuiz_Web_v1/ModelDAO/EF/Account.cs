namespace ModelDAO.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        [Key]
        [StringLength(20)]
        public string CodeAccount { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? Permission { get; set; }

        public bool? Status { get; set; }

        public virtual Member Member { get; set; }
    }
}
