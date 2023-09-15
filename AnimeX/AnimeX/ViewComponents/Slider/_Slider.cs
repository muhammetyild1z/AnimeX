using Microsoft.AspNetCore.Mvc;

namespace AnimeX.ViewComponents.Slider
{
    public class _Slider:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
       
    }
}
