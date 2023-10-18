﻿
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using AnimeX.EntityLayer;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
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

        public  async Task< IActionResult> Izle(int AnimeID_Sezon, int bolumNo, int sezonNo , string bolumUrl , int id)
        {

            if (AnimeID_Sezon==0)
            {
                AnimeID_Sezon = id;
                UserFavori userFavori = new UserFavori();
               userFavori.UserFavAnimeID = id;
                userFavori.animeler = animeManager.TGetByID(id);
                userFavori.appUser= await _userManager.FindByNameAsync(User.Identity.Name);
                userFavori.UserFavUserID = userFavori.appUser.Id;

                Context c = new Context();
                c.userFavoris.Add(userFavori);
                c.SaveChanges();
            }

            ViewBag.bolumUrl = string.Empty;
            ViewBag.sezonsBolum = string.Empty;
            ViewBag.AnimeName = animeManager.TGetByID(AnimeID_Sezon).AnimeAdi;
            ViewBag.AnimeID = animeManager.TGetByID(AnimeID_Sezon).AnimeID;
            ViewBag.AnimeKapakImg = animeManager.TGetByID(AnimeID_Sezon).AnimeKapakImg;
            ViewBag.CommentCount = commentManager.TGetList().Where(x => x.AnimeCommentID == AnimeID_Sezon).Count();

            if (sezonNo != 0)
            {
                var values = animeBolumManager.TGetList().Where(x => x.BolumAnimeID == AnimeID_Sezon).Where(x => x.SezonsNo == sezonNo).ToList();
                if (bolumUrl == null)
                {
                    bolumUrl = values.Select(x => x.BolumUrl).FirstOrDefault();
                }
                ViewBag.BolumUrl = bolumUrl;
                return View(values);
            }
            if (sezonNo == 0)
            {               
                sezonNo = 1;
                var values = animeBolumManager.TGetList().Where(x => x.BolumAnimeID == AnimeID_Sezon).Where(x => x.SezonsNo == sezonNo).ToList();
                ViewBag.BolumUrl = bolumUrl;
                return View(values);
            }

            return View();
        }



        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CommentAdd(Comments p, int animeID)
        {
            CommentManager cm = new CommentManager(new efCommentRepository(new Context()));
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p.UserImg = user.UserImg;
            p.AnimeCommentID = animeID;
            p.CommentDate = DateTime.Now;
            cm.TInsert(p);
            return RedirectToAction("Izle", "AnimeIzle", new { AnimeID_Sezon = animeID });
        }
    }
}
