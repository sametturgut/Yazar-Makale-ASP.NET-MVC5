namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MakaleYazar")]
    public partial class MakaleYazar
    {
        [Key]
        public int No { get; set; }

        public int KullaniciNo { get; set; }

        public int MakaleNo { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Makale Makale { get; set; }
    }
}
