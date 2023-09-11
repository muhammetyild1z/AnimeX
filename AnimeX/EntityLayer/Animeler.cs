﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Animeler
    {
        public int AnimeID { get; set; }
        public string AnimeAdi { get; set; }
        public string AnimeDetay { get; set; }
        public string AnimeKisaDetay { get; set; }
        public string AnimeUyarlamasi { get; set; }
        public string IMDb { get; set; }
        public int Like { get; set; }
        public bool status { get; set; }
        public DateTime AnimeEklenmeTarihi { get; set; }
        public DateTime AnimeCikisTarihi { get; set; }

    }
}