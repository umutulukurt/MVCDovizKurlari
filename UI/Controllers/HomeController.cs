using BML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            DovizKuruIslemleri islemler = new DovizKuruIslemleri();
            IEnumerable<DovizKuruModel> liste = islemler.DovizKurlari();
            return View(liste);
        }
  
        public ActionResult DovizKuru(string CurrencyCode)
        {
            DovizKuruIslemleri islemler = new DovizKuruIslemleri();
            var kur = islemler.DovizKurlari().FirstOrDefault(a => a.CurrencyCode.Equals(CurrencyCode));
            if (kur == null)
                return Json("404");
            return Json(kur, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}