using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.EntityLayer
{
    public class AnimeSezon
    {
        public int ID { get; set; }
        public int Sezonlar { get; set; }
        public int Bolumler { get; set; }
        public string SezonIzlekapakImg { get; set; }
        public string SezonIzleUrl{ get; set; }
        public DateTime BolumCreateDate{ get; set; }
        public DateTime SezonCreateDate{ get; set; }
        public Animeler animeID { get; set; }
    }
}
