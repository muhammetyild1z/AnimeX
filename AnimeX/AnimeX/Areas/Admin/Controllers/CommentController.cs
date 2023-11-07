using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using X.PagedList;

namespace AnimeX.UI.Areas.Admin.Controllers
{

    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));

        [Route("[controller]/[action]/{id?}")]
        [Area("Admin")]
        public IActionResult CommentCheck(int page = 1)
        {
            var comments = commentManager.CommentUserAndAnimeInclude().Where(x => x.CommentStatus == false);
            return View(comments.ToPagedList(page, 12));
        }

        [Route("Admin/[controller]/[action]/{id?}")]
        public IActionResult CommentRemove(int id)
        {
            var comment = commentManager.TGetList().Where(x => x.CommentID == id).FirstOrDefault();
            commentManager.TDelete(comment);

            return RedirectToAction("CommentCheck");
        }
    
        [Route("Admin/[controller]/[action]/{id?}")]
        public IActionResult CommentApprove(int id)
        {
            var comment = commentManager.TGetList().Where(x => x.CommentID == id).FirstOrDefault();
            comment.CommentStatus = true;
            commentManager.TUpdate(comment, comment);

            return RedirectToAction("CommentCheck");
        }
        [Route("[controller]/[action]/{id?}")]
        [Area("Admin")]
        public IActionResult CommentList(int page = 1)
        {
            var comments = commentManager.CommentUserAndAnimeInclude().Where(x => x.CommentStatus == true);
            return View(comments.ToPagedList(page, 20));
        }
        [Route("Admin/[controller]/[action]/{id?}")]
        public IActionResult CommentRemoveStatusTrue(int id)
        {
            var comment = commentManager.TGetList().Where(x => x.CommentID == id).FirstOrDefault();
            commentManager.TDelete(comment);

            return RedirectToAction("CommentList");
        }
    }
}
