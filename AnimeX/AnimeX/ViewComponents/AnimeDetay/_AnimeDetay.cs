﻿using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeX.UI.ViewComponents.AnimeDetay
{
    public class _AnimeDetay:ViewComponent
    {
        public IViewComponentResult Invoke(int animeID)
        {
            AnimelerManager am = new AnimelerManager(new efAnimelerRepository(new Context()));
            var value = am.TGetByID(animeID);
            return View(value);
        }
    }
}
