using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Linq;
using X.PagedList;

namespace AnimeX.UI.Controllers
{
    public class AnimelerController : Controller
    {
        AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
        CategoriesManager amn = new CategoriesManager(new efCatagoriesRepository(new Context()));
        CategoryAnimeManeger amnn = new CategoryAnimeManeger(new efCategoryAnimeRepository(new Context()));
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

            var values = am.TGetList();


            if (animeadi != null)
            {
                values = values.Where(x => x.AnimeAdi.Contains(animeadi)).OrderBy(x => x.AnimeAdi).ToList();
            }
            else if (idmb != 0)
            {

                values = values.Where(x => float.Parse(x.IMDb, CultureInfo.InvariantCulture.NumberFormat) >= idmb).OrderByDescending(x => x.IMDb).ToList();
            }

            else if (dateSelect != "Çıkış Tarihi")
            {
                values = values.Where(x => x.AnimeCikisTarihi.Year.ToString() == dateSelect).ToList();
            }
            else if (kategoriSelect != "Kategori seç")
            {

                var catID = amn.TGetList().Where(x => x.KategoriAdi == kategoriSelect).Select(x => x.kategoriID).FirstOrDefault();

                var animeid = amnn.TGetList().Where(x => x.KategoriID == catID).Select(x => x.AnimeID).ToList();
                
                for (int i = 0; i < animeid.Count; i++)
                {

                    var animeler = am.TGetList().Where(x => x.AnimeID == animeid[i]).ToList();
                    values = animeler;
                    
                }
                var b = values;

            }
            else if (sirlaSelect == "Alfabetik")
            {
                values = values.OrderBy(x => x.AnimeAdi).ToList();
            }
            else if (sirlaSelect == "IDMb Puanına Göre")
            {
                values = values.OrderByDescending(x => x.IMDb).ToList();
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
