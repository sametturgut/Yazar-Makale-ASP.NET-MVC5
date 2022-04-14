using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace samet_turgut.Controllers
{
    public class KategoriEkleController : Controller
    {
        private Kategori yeniKategori;

        // GET: KategoriEkle
        public ActionResult KategoriEkle()
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            var liste = model.Kategori.ToList();

            return View("KategoriEkle", liste);
        }

        [HttpPost]
        //[Attribute.Loglama]
        public ActionResult KategoriEkle(DataModel.Kategori yeniKategori)
        {

            DataModel.MakaleModel model = new DataModel.MakaleModel();

            var cerez = Request.Cookies["Oturum"];
            if (cerez != null)
            {
                FormsAuthenticationTicket bilet = FormsAuthentication.Decrypt(cerez.Value);

                JavaScriptSerializer serilestir = new JavaScriptSerializer();
                var kullaniciBilgi = serilestir.Deserialize<Models.KullaniciBilgi>(bilet.UserData);

                yeniKategori.KullaniciNo = kullaniciBilgi.No;
                model.Kategori.Add(yeniKategori);
                model.SaveChanges();
            }
            return RedirectToAction("KategoriEkle");
        }
    }
}