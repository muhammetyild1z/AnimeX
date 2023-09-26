
using AnimeX.BusinnessLayer.Concrate;
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
        AnimeSezonManager am = new AnimeSezonManager(new efAnimeSezonRepository(new Context()));
        AnimelerManager anm = new AnimelerManager(new efAnimelerRepository(new Context()));
        SezonsManager sm=new SezonsManager(new efSezonsRepository(new Context()));

        public IActionResult Izle(int AnimeID_Sezon)
        {
           
            ViewBag.AnimeName = anm.TGetByID(AnimeID_Sezon).AnimeAdi;
            ViewBag.AnimeID = anm.TGetByID(AnimeID_Sezon).AnimeID;
            ViewBag.AnimeKapakImg = anm.TGetByID(AnimeID_Sezon).AnimeKapakImg;   
            
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
            return RedirectToAction("Izle", "AnimeIzle", new { AnimeID_Sezon= animeID });
        }
    }
}
