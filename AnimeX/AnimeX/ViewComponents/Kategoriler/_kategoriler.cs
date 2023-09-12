using AnimeX.DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.Kategoriler
{
    public class _kategoriler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var context = new Context();
            var values =context.Categories.ToList();
            return View(values);
        }
    }
}
