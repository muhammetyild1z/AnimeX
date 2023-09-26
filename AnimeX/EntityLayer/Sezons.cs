using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.EntityLayer
{
    public class Sezons
    {
        [Key]
        public int ID { get; set; }
        public int Sezon_SezonID { get; set; }      
        public int Anime_id { get; set; }
        public AnimeSezon? animeSezon { get; set; }
    }
}
