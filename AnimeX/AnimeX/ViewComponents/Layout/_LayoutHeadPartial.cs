using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.Layout
{
    public class _LayoutHeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
