namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        [Key]
        public int No { get; set; }

        public int IP { get; set; }

        [Required]
        [StringLength(50)]
        public string Tarayici { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        [Required]
        [StringLength(10)]
        public string Metot { get; set; }

        [Required]
        [StringLength(10)]
        public string Parametre { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }
        public string MetotAdi { get; set; }
        public int KullaniciNumara { get; set; }
    }
}
