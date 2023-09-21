
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
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
        [HttpPost]
        public IActionResult CommentAdd(string CommentContent, int animeID)
        {
            CommentManager cm= new CommentManager(new efCommentRepository(new Context()));
            Comments comment = new Comments()
            {
                CommentContent = CommentContent,
                CommentDate = DateTime.Now,
                UserImg = "https://r.resimlink.com/W2K3t-gaJPqd.jpg",
                UserName = "test",
                AnimeCommentID = 1
            };
            cm.TInsert(comment);
            return View();
        }
    }
}
