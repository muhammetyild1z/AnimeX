using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using X.PagedList;

namespace AnimeX.UI.Controllers
{
    public class AnimelerController : Controller
    {
        AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
        CategoriesManager amn = new CategoriesManager(new efCatagoriesRepository(new Context()));
        [HttpGet]
        public IActionResult Index(int page = 1)
        {
            ViewBag.category = amn.TGetList().OrderBy(x => x.KategoriAdi).Select(x => x.KategoriAdi);
            ViewBag.categoryDate = am.TGetList().OrderByDescending(x => x.AnimeCikisTarihi.Year).Select(x => x.AnimeCikisTarihi.Year).Distinct();
            return View(am.TGetList().ToPagedList(page, 18));

        }
        [HttpPost]
        public IActionResult Index(int idmb, string animeadi, string sirlaSelect, string dateSelect, string kategoriSelect, int page = 1)
        {
            var categoryID = amn.TGetList().Where(x => x.KategoriAdi == kategoriSelect).Select(x => x.kategoriID).FirstOrDefault();


            var values = new List<Animeler>();
            values = am.TGetList();


            if (animeadi != null)
            {
                values.OrderBy(x => x.AnimeAdi==animeadi).ToList();
            }
            else if (idmb != 0)
            {
                values.Where(x =>Convert.ToInt32( x.IMDb) >= idmb).OrderBy(x=>x.IMDb).ToList();
            }

            else if (dateSelect != "Çıkış Tarihi")
            {
                values.Where(x => x.AnimeCikisTarihi.Year.ToString() == dateSelect).ToList();
            }
            else if (kategoriSelect != "Kategori seç")
            {
            //  var animeler= values.Where(x => x.categoryAnimes.Where(x=>x.KategoriID==categoryID).Select(x => x.AnimeID));
              //  values.Where(x=>x.AnimeID==animeler).ToList();
            }
            else if (sirlaSelect == "Alfabetik")
            {
                values = values.OrderBy(x => x.AnimeAdi).ToList();
            }
            else if (sirlaSelect == "IDMb Puanına Göre")
            {
                values = values.OrderBy(x => x.IMDb).ToList();
            }
            else if (sirlaSelect == "Eklenme Tarihine Göre")
            {
                values = values.OrderBy(x => x.AnimeEklenmeTarihi).ToList();
            }
            ViewBag.category = amn.TGetList().OrderBy(x => x.KategoriAdi).Select(x => x.KategoriAdi);
            ViewBag.categoryDate = am.TGetList().OrderByDescending(x => x.AnimeCikisTarihi.Year).Select(x => x.AnimeCikisTarihi.Year).Distinct();
            return View(values.ToPagedList(page, 10));
        }


    }
}
