using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.Footer
{
    public class _Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
