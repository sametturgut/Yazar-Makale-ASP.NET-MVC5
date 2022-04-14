using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace samet_turgut
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Makale", action = "Anasayfa", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "MakaleKategoriListele",
               url: "MakaleKategoriListele",
               defaults: new { controller = "Makale", action = "MakaleKategoriGetir" }
           );
            routes.MapRoute(
                name: "MakaleListele",
                url: "MakaleListele",
                defaults: new { controller = "Makale", action = "MakaleListele" }
           );
            routes.MapRoute(
                    name: "UnvanEklemeSayfasiGetir",
                    url: "UnvanEkle",
                    defaults: new { controller = "Makale", action = "UnvanEkle" }
           );
            routes.MapRoute(
                    name: "KullaniciEklemeSayfasiGetir",
                    url: "KullaniciEkle",
                    defaults: new { controller = "Makale", action = "KullaniciEkle" }
           );
            routes.MapRoute(
                    name: "MakaleEklemeSayfasiGetir",
                    url: "MakaleEkle",
                    defaults: new { controller = "Makale", action = "MakaleEkle" }
           );
            routes.MapRoute(
                    name: "KategoriEklemeSayfasiGetir",
                    url: "KategoriEkle",
                    defaults: new { controller = "Makale", action = "KategoriEkle" }
           );
            routes.MapRoute(
                    name: "BolumEklemeSayfasiGetir",
                    url: "BolumEkle",
                    defaults: new { controller = "Makale", action = "BolumEkle" }
           );
        }

    }
}
