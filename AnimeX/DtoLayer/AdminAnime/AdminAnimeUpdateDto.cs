using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DtoLayer.AdminAnime
{
    public class AdminAnimeUpdateDto
    {
        public int AnimeID { get; set; }
        public string AnimeAdi { get; set; }
        public string AnimeDetay { get; set; }
        public string? AnimeKisaDetay { get; set; }
        public string AnimeUyarlamasi { get; set; }
        public string IMDb { get; set; }

        public bool status { get; set; }
        public string AnimeImg { get; set; }
        public string? AnimeKapakImg { get; set; }

        public DateTime AnimeCikisTarihi { get; set; }
    }
}
