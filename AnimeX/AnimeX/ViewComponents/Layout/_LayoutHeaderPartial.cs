using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.Layout
{
    public class _LayoutHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
