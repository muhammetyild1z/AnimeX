using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.Script
{
    public class _Script:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
