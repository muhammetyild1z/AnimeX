
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Controllers
{
    public class AnimeIzleController : Controller
    {
        public IActionResult Izle(int AnimeID_Sezon)
        {
            AnimelerManager anm = new AnimelerManager(new efAnimelerRepository(new Context()));
            AnimeSezonManager am = new AnimeSezonManager(new efAnimeSezonRepository(new Context()));      
          
            ViewBag.AnimeName = anm.TGetByID(AnimeID_Sezon).AnimeAdi;
            ViewBag.AnimeID = anm.TGetByID(AnimeID_Sezon).AnimeID;
            var values = am.TGetList().Where(x => x.Anime_ID_Sezon == AnimeID_Sezon).ToList();
            var sezon=values.DistinctBy(x=>x.Sezonlar).ToList();
        
             ViewBag.AnimeImg= values.Select(x=>x.SezonIzlekapakImg).FirstOrDefault();
             ViewBag.Sezonlar =values.Select(x=>x.Sezonlar).Distinct().ToList();
             ViewBag.Sezonlar =values.Select(x=>x.Bolumler).Distinct().ToList();
            return View(values);
        }
        [Authorize]
        [HttpPost]
        public IActionResult CommentAdd( Comments p, int animeID)
        {
            var a = ViewBag.AnimeID;
            CommentManager cm= new CommentManager(new efCommentRepository(new Context()));
              
            p.animeler.AnimeID = p.AnimeCommentID;        
            p.CommentDate = DateTime.Now;          
            cm.TInsert(p);
            return RedirectToAction("Izle","AnimeIzle",new {animeID});
        }
    }
}
