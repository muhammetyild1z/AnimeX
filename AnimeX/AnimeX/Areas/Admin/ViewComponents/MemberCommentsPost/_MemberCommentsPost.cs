using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.ViewComponents.MemberCommentsPost
{
    public class _MemberCommentsPost:ViewComponent
    {
        public IViewComponentResult Invoke(int memberid)
        {
            CommentManager commentManager = new CommentManager(new efCommentRepository(new Context()));
            var memberComments= commentManager.CommentUserAndAnimeInclude().Where(x=>x.CommentUserId== memberid).ToList();
            return View(memberComments);
        }
    }
}
