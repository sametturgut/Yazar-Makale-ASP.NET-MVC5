namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dergi")]
    public partial class Dergi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dergi()
        {
            Makale = new HashSet<Makale>();
        }

        [Key]
        public int No { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Column(TypeName = "date")]
        public DateTime BaslamaYili { get; set; }

        public int Endeks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makale { get; set; }
    }
}
