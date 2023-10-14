using AnimeX.EntityLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnimeBolumler
    {
        [Key]
        public int AnimelerBolumId { get; set; }
        public string BolumUrl { get; set; }
        public int BolumNo { get; set; }
        public List<AnimeSezonlar> AnimeSezon { get; set; }
        public int SezonsNo { get; set; }
        public int AnimeID_Bolum { get; set; }      
        public DateTime BolumCreateDate { get; set; }
    }
}
