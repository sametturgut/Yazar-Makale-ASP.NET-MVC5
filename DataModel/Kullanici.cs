namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            MakaleYazar = new HashSet<MakaleYazar>();
        }

        [Key]
        public int No { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }

        [Column(TypeName = "date")]
        public DateTime DogumTarihi { get; set; }

        [Required]
        [StringLength(10)]
        public string Cinsiyet { get; set; }

        [Required]
        [StringLength(255)]
        public string Eposta { get; set; }

        [Required]
        [StringLength(11)]
        public string TcKimlikNo { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string Parola { get; set; }

        public int UnvanNo { get; set; }

        public int BolumNo { get; set; }

        public virtual Bolum Bolum { get; set; }

        public virtual Unvan Unvan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MakaleYazar> MakaleYazar { get; set; }
    }
}
