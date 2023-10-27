using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.Areas.Admin.ViewComponents.FeedbackMembers
{
    public class _FeedbackMembers:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
