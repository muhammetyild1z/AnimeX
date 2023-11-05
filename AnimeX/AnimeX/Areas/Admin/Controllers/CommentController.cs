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
        [Area("Admin")]
        [HttpGet]
        public IActionResult CommentCheck(int page=1)
        {
            var comments = commentManager.CommentUserAndAnimeInclude().Where(x=>x.CommentStatus==false);
            return View(comments.ToPagedList(page,12));
        }
       
        public IActionResult CommentRemove(int id)
        {
           var comment= commentManager.TGetList().Where(x=>x.CommentID==id).FirstOrDefault();
            commentManager.TDelete(comment);
            //YONLENDIRME YAPILACAK SAYFA REFLESH OLACAK
            return View("CommentCheck");
        }
        public IActionResult CommentApprove(int id)
        {
            var comment = commentManager.TGetList().Where(x => x.CommentID == id).FirstOrDefault();
            comment.CommentStatus= true;
            commentManager.TUpdate(comment, comment);
            //YONLENDIRME YAPILACAK SAYFA REFLESH OLACAK
            return View("CommentCheck");
        }
    }
}
