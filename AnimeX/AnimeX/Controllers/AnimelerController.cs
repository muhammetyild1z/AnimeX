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
        AnimelerManager aniemlerManager = new AnimelerManager(new efAnimelerRepository(new Context()));
        CategoriesManager categoriesManager = new CategoriesManager(new efCatagoriesRepository(new Context()));
        CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));
        CategoryAnimeManeger categoryManger = new CategoryAnimeManeger(new efCategoryAnimeRepository(new Context()));
        [HttpGet]
        public IActionResult Index(int page = 1)
        {
            ViewBag.category = categoriesManager.TGetList().OrderBy(x => x.KategoriAdi).Select(x => x.KategoriAdi);          
            ViewBag.categoryDate = aniemlerManager.TGetList().OrderByDescending(x => x.AnimeCikisTarihi.Year).Select(x => x.AnimeCikisTarihi.Year).Distinct();
        
            return View(aniemlerManager.GetCommentIncludeAnimeler().ToPagedList(page, 24));

        }
        [HttpPost]
        public IActionResult Index(int idmb, string animeadi, string sirlaSelect, string dateSelect, string kategoriSelect, int page = 1)
        {
            // var categoryID = categoriesManager.TGetList().Where(x => x.KategoriAdi == kategoriSelect).Select(x => x.kategoriID).FirstOrDefault();
            ViewBag.category = categoriesManager.TGetList().OrderBy(x => x.KategoriAdi).Select(x => x.KategoriAdi);
            ViewBag.categoryDate = aniemlerManager.TGetList().OrderByDescending(x => x.AnimeCikisTarihi.Year).Select(x => x.AnimeCikisTarihi.Year).Distinct();
            var values = aniemlerManager.GetCommentIncludeAnimeler();


            if (animeadi != null)
            {
                values = values.Where(x => x.AnimeAdi.ToLower().Contains(animeadi.ToLower())).OrderBy(x => x.AnimeAdi).ToList();
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

                var catID = categoriesManager.TGetList().Where(x => x.KategoriAdi == kategoriSelect).Select(x => x.kategoriID).FirstOrDefault();

                var animeid = categoryManger.TGetList().Where(x => x.KategoriID == catID).Select(x => x.AnimeID).ToList();
                 List<Animeler> value= new List<Animeler>();
                for (int i = 0; i < animeid.Count; i++)
                {
                    value.Add(aniemlerManager.GetCommentIncludeAnimeler().Where(x => x.AnimeID == animeid[i]).FirstOrDefault());
                }

                return View(value.ToPagedList(page, 10));
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
           
            return View(values.ToPagedList(page, 10));
        }


    }
}
