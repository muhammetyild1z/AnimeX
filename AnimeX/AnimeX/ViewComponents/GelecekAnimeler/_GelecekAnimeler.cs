using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.GelecekAnimeler
{
    public class _GelecekAnimeler:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
