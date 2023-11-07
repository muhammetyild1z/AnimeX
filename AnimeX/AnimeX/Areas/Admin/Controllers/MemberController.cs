using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.Controllers
{
    public class MemberController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));

        public MemberController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [Area("Admin")]
        [Route("[controller]/[action]/{id?}")]
        public async Task< IActionResult> Memberdetails(string id)
        {
            var userDetail =await _userManager.FindByIdAsync(id);
            return View(userDetail);
        }
        public IActionResult MemberCommentRemove(int id)
        {          
            var userComment = commentManager.CommentUserInclude().Where(x=>x.CommentID== id).FirstOrDefault();
            commentManager.TDelete(userComment);
            return RedirectToAction("Memberdetails", new {id=userComment.appUser.Id});
        }
    }
}
