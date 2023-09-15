using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnimeSezon
    {
        [Key]
        public int ID { get; set; }
        public int Sezonlar { get; set; }
        public int Bolumler { get; set; }
        public string SezonIzlekapakImg { get; set; }
        public string SezonIzleUrl { get; set; }
        public DateTime BolumCreateDate { get; set; }
        public DateTime SezonCreateDate { get; set; }
        public Animeler AnimeID_Sezon { get; set; }
        public int Anime_ID_Sezon { get; set; }
    }
}
