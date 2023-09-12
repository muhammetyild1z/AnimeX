using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace AnimeX.UI.ViewComponents.Kategoriler
{
    public class _kategoriler:ViewComponent
    {
        

        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
