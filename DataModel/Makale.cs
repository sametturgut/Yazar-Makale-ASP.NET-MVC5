namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Makale")]
    public partial class Makale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makale()
        {
            MakaleKategori = new HashSet<MakaleKategori>();
            MakaleYazar = new HashSet<MakaleYazar>();
        }

        [Key]
        public int No { get; set; }

        [Required]
        [StringLength(150)]
        public string Ad { get; set; }

        [Column(TypeName = "date")]
        public DateTime YayinTarihi { get; set; }

        public int DergiNo { get; set; }

        public int MakaleTuruNo { get; set; }

        public int EndeksNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Ozet { get; set; }

        public virtual Dergi Dergi { get; set; }

        public virtual Endeks Endeks { get; set; }

        public virtual MakaleTur MakaleTur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MakaleKategori> MakaleKategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MakaleYazar> MakaleYazar { get; set; }
    }
}
