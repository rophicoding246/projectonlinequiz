namespace DAOModel.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GeneralQuestion")]
    public partial class GeneralQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GeneralQuestion()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        [StringLength(20)]
        public string CodeGeneralQuestion { get; set; }

        [StringLength(1000)]
        public string Text { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
