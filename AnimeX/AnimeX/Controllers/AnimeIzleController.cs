
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using AnimeX.EntityLayer;
using EntityLayer;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace AnimeX.UI.Controllers
{
    public class AnimeIzleController : Controller
    {
        //ViewBag.UserProfile= await _userManager.FindByIdAsync(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value);


        private readonly UserManager<AppUser> _userManager;

        public AnimeIzleController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        AnimelerManager animeManager = new AnimelerManager(new efAnimelerRepository(new Context()));
        AnimeBolumsManager animeBolumManager = new AnimeBolumsManager(new efAnimeBolumsRepository(new Context()));
        AnimeSezonlarManager animeSezonManager = new AnimeSezonlarManager(new efAnimeSezonlarRepository(new Context()));
        CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));
        UserFavoriManager favoriUserManager = new UserFavoriManager(new efUserFavoriRepository(new Context()));

        public IActionResult Izle(int AnimeID_Sezon, int sezonNo, int bolumNo)
        {
            if (sezonNo == 0)
            {
                ViewBag.sezonNo = 1;
            }
            else
            {
                ViewBag.sezonNo = sezonNo;
            }
            if (bolumNo == 0)
            {
                ViewBag.BolumUrl = animeBolumManager.TGetList().Where(x => x.BolumAnimeID == AnimeID_Sezon)
                    .Where(x => x.SezonsNo == 1)
                    .Where(x => x.BolumNo == 1)
                    .FirstOrDefault();
            }
            ViewBag.BolumUrl = animeBolumManager.TGetList().Where(x => x.BolumAnimeID == AnimeID_Sezon)
                .Where(x => x.SezonsNo == sezonNo)
                .Where(x => x.BolumNo == bolumNo)
                .Select(x => x.BolumUrl)
                .FirstOrDefault();

            var values = animeManager.TGetByID(AnimeID_Sezon);


            return View(values);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CommentAdd(Comments p, int animeID)
        {
            CommentManager cm = new CommentManager(new efCommentRepository(new Context()));
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            p.CommentUserId = user.Id;
            p.CommentStatus = false;
            p.AnimeCommentID = animeID;
            p.CommentDate = DateTime.Now;
            cm.TInsert(p);
            return RedirectToAction("Izle", "AnimeIzle", new { AnimeID_Sezon = animeID });
        }

        public async Task<IActionResult> Fav(int AnimeID_Sezon)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);           
            UserFavori userFavori = new UserFavori();
            userFavori.FavAnimeID = AnimeID_Sezon;
            userFavori.FavUserId = user.Id;
            favoriUserManager.Insert(userFavori);
            return RedirectToAction("Izle", "AnimeIzle", new { AnimeID_Sezon = AnimeID_Sezon });
        }
        public async Task<IActionResult> FavDel(int AnimeID_Sezon)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
           var FavRemote= favoriUserManager.GetList().Where(x=>x.FavAnimeID==AnimeID_Sezon).Where(x=>x.FavUserId==user.Id).FirstOrDefault();
            favoriUserManager.Delete(FavRemote);
            return RedirectToAction("Izle", "AnimeIzle", new { AnimeID_Sezon = AnimeID_Sezon });
        }
    }
}
