using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.UserFavoriComment
{
    public class _UserFavoriComment:ViewComponent
    {
        public IViewComponentResult Invoke(int id )
        {
            CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));

            var values = commentManager.CommentUserAndAnimeInclude().Where(x=>x.CommentUserId== id).ToList();
            return View(values);
        }
    }
}
