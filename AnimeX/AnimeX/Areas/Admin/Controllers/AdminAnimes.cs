using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using AnimeX.DtoLayer.AdminAnime;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using X.PagedList;

namespace AnimeX.UI.Areas.Admin.Controllers
{
    public class AdminAnimes : Controller
    {
        AnimelerManager animelerManager = new AnimelerManager(new efAnimelerRepository(new Context()));
        CategoryAnimeManeger categoryAnimeManager = new CategoryAnimeManeger(new efCategoryAnimeRepository(new Context()));

        [Area("Admin")]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult Animelers(int page = 1)
        {

            var values = animelerManager.TGetList().ToPagedList(page, 14);
            return View(values);
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult AnimeAdd()
        {
           return View();
        }
       
        [HttpPost]
        [Area("Admin")]
        public IActionResult AnimeAdd(Animeler animeAdd)
        {
            animeAdd.AnimeEklenmeTarihi=DateTime.Now;
            animelerManager.TInsert(animeAdd);
            return RedirectToAction("Animelers", "AdminAnimes");
        }
        [Area("Admin")]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult AnimeInfo(int id)
        {
            var values = animelerManager.GetCommentIncludeAnimeler().Where(x=>x.AnimeID==id).FirstOrDefault();
            ViewBag.category= categoryAnimeManager.GetCategoriesIncludecategoryAnime().Where(x=>x.AnimeID==id).Select(x=>x.categories.KategoriAdi).Distinct().ToList();
            return View(values);

        }
        [HttpPost]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult AnimeInfo(AdminAnimeUpdateDto animeUpdate  )
        {
            var anime = animelerManager.TGetList().Where(x => x.AnimeID == animeUpdate.AnimeID).FirstOrDefault();
          
            anime.AnimeAdi = animeUpdate.AnimeAdi;
            anime.AnimeDetay = animeUpdate.AnimeDetay;
            anime.AnimeKisaDetay = animeUpdate.AnimeKisaDetay;
            anime.AnimeUyarlamasi = animeUpdate.AnimeUyarlamasi;
            anime.IMDb = animeUpdate.IMDb;
            anime.status = animeUpdate.status;
            anime.AnimeImg = animeUpdate.AnimeImg;
            anime.AnimeKapakImg = animeUpdate.AnimeKapakImg;
            anime.AnimeCikisTarihi = animeUpdate.AnimeCikisTarihi;
            animelerManager.TUpdate(anime, anime);
            return RedirectToAction("AnimeInfo", "AdminAnimes", new {id=animeUpdate.AnimeID});

        }

    }
}
