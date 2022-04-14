using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace samet_turgut.Models
{
    public class Makale
    {
        public List<DataModel.Makale> MakaleListe { get; set; }
        public List<DataModel.Kategori> KategoriListe { get; set; }
        public List<DataModel.Kullanici> YazarListe { get; set; }
    }
}