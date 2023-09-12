
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;

using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.Kategoriler
{
    public class _kategoriler : ViewComponent
    {


        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
