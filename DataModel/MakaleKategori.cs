namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MakaleKategori")]
    public partial class MakaleKategori
    {
        [Key]
        public int No { get; set; }

        public int MakaleNo { get; set; }

        public int KategoriNo { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Makale Makale { get; set; }
    }
}
