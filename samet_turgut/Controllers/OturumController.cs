using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace samet_turgut.Controllers
{
    public class OturumController : Controller
    {
        // GET: Oturum
        public ActionResult OturumAc()
        {
            return View("OturumAc");
        }
        [HttpPost]
        public ActionResult Oturum(DataModel.Kullanici kullanici)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();

            var kullaniciBilgi = model.Kullanici.FirstOrDefault(k => k.KullaniciAdi == kullanici.KullaniciAdi && k.Parola == kullanici.Parola);
            if (kullaniciBilgi != null)
            {
                JavaScriptSerializer serilestir = new JavaScriptSerializer();

                Models.KullaniciBilgi oturumBilgi = new Models.KullaniciBilgi();
                oturumBilgi.No = kullaniciBilgi.No;
                oturumBilgi.Ad = kullaniciBilgi.Ad;
                oturumBilgi.Soyad = kullaniciBilgi.Soyad;
                oturumBilgi.KullaniciAdi = kullaniciBilgi.KullaniciAdi;


                string kullaniciVerisi = serilestir.Serialize(oturumBilgi);

                FormsAuthenticationTicket bilet = new FormsAuthenticationTicket(
                    1, kullaniciBilgi.KullaniciAdi,
                    DateTime.Now, DateTime.Now.AddMinutes(20),
                    false, kullaniciVerisi, FormsAuthentication.FormsCookiePath);

                string sifreliBilet = FormsAuthentication.Encrypt(bilet);

                HttpCookie cerez = new HttpCookie("Oturum", sifreliBilet);

                cerez.HttpOnly = true;
                Response.Cookies.Add(cerez);

                return RedirectToAction("KullaniciEkle", "Kullanici");
            }
            else
            {
                return RedirectToAction("OturumAc");
            }

        }

        public ActionResult OturumuKapat()
        {
            FormsAuthentication.SignOut();
            var cerez = Request.Cookies["Oturum"];
            cerez.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cerez);
            Request.Cookies.Remove("Oturum");

            return RedirectToAction("OturumAc");

        }
    }
}