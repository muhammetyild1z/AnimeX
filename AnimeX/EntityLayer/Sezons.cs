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
        public int SezonID { get; set; }
        public int BolumID { get; set; }
        public AnimeSezon AnimeBolumID_Sezon { get; set; }
    }
}
