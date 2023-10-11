
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using AnimeX.EntityLayer;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
        AnimeBolumlerManager animeBolumManager = new AnimeBolumlerManager(new efAnimeBolumlerRepository(new Context()));
        AnimeSezonlarManager animeSezonManager = new AnimeSezonlarManager(new efAnimeSezonlarRepository(new Context()));
        CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));

        public IActionResult Izle(int AnimeID_Sezon , int bolumNo , int SezonNo)
        {
            ViewBag.bolumUrl=string.Empty;
            ViewBag.sezonsBolum=string.Empty;

            ViewBag.AnimeName = animeManager.TGetByID(AnimeID_Sezon).AnimeAdi;
            ViewBag.AnimeID = animeManager.TGetByID(AnimeID_Sezon).AnimeID;
            ViewBag.AnimeKapakImg = animeManager.TGetByID(AnimeID_Sezon).AnimeKapakImg;
            ViewBag.CommentCount = commentManager.TGetList().Where(x => x.AnimeCommentID == AnimeID_Sezon).Count();

            if (bolumNo == 0)
            {
                ViewBag.bolumUrl = animeBolumManager.TGetByID(AnimeID_Sezon).BolumUrl;
            }
            else
            {
                ViewBag.bolumUrl = animeBolumManager.TGetList().Where(x => x.AnimeID == AnimeID_Sezon).Where(x=>x.BolumNo== bolumNo).Select(x => x.BolumUrl).FirstOrDefault();
                
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
