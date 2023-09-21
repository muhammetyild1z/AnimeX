using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.Comments
{
    public class _Comments:ViewComponent
    {
        public IViewComponentResult Invoke(int animeID)
        {
            CommentManager cm = new CommentManager(new efCommentRepository(new Context()));
            var comment= cm.TGetList().Where(x=>x.AnimeCommentID==animeID).OrderBy(x=>x.CommentDate).ToList();

            return View(comment);
        }
    }
}
