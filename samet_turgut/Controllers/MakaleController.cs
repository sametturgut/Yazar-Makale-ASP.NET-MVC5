using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace samet_turgut.Controllers
{
    public class MakaleController : Controller
    {
        [HttpGet]
        public ActionResult Anasayfa()
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            var kategoriListesi = model.Kategori.ToList();
            var makaleListesi = model.Makale.ToList();
            var sonyazarlarListesi = model.Kullanici.ToList();
            return View("Anasayfa", Tuple.Create(kategoriListesi, makaleListesi, sonyazarlarListesi));
        }
        public ActionResult UnvanEkle(DataModel.Unvan yeniUnvan)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            model.Unvan.Add(yeniUnvan);
            model.SaveChanges();
            return RedirectToAction("UnvanEkle");//View("UnvanEkle");
        }
        public ActionResult BolumEkle(DataModel.Bolum yeniBolum)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            model.Bolum.Add(yeniBolum);
            model.SaveChanges();
            return RedirectToAction("BolumEkle");//View("BolumEkle");
        }
        public ActionResult KategoriEkle(DataModel.Kategori yeniKategori)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            model.Kategori.Add(yeniKategori);
            model.SaveChanges();
            return RedirectToAction("KategoriEkle");//View("KategoriEkle");
        }
        public ActionResult MakaleEkle(DataModel.Makale yeniMakale)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            model.Makale.Add(yeniMakale);
            model.SaveChanges();
            return RedirectToAction("MakaleEkle");//View("MakaleEkle");
        }
        public ActionResult KullaniciEkle(DataModel.Kullanici yeniKullanici)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            model.Kullanici.Add(yeniKullanici);
            model.SaveChanges();
            return RedirectToAction("KullaniciEkle");//View("KullaniciEkle");
        }

        public ActionResult MakaleKategoriGetir(int KategoriNo, int UnvanNo)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            var secilenKategori = model.Kategori.FirstOrDefault(k => k.No == KategoriNo);
            var makaleListe = secilenKategori.MakaleKategori.Count;

            return View("MakaleKategoriGetir", makaleListe);
        }

        public ActionResult MakaleListele(int MakaleListele)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            var seciliKategori = model.Kategori.FirstOrDefault(k => k.No == MakaleListele);
            string ad = seciliKategori.Ad;
            var no = seciliKategori.MakaleKategori.Count;
            return View("MakaleListele", seciliKategori);
        }

        public ActionResult MakaleYazarListele(int MakaleNo)
        {
            DataModel.MakaleModel model = new DataModel.MakaleModel();
            //var seciliYazar = model.MakaleYazar.FirstOrDefault(m => m.No == MakaleYazarListele).ToList();
            //string ad = seciliYazar.MakaleYazar.Ad;
            //var no = seciliYazar.MakaleYazar.No.Count;
            return View("MakaleYazarListele"); /*seciliYazar*/
        }

    }
}