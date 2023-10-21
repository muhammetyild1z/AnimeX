using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnimeSezonlar
    {
        [Key]
        public int AnimelerSezonId { get; set; }
        public int SezonNo { get; set; }
        //public AnimeBolumler? Bolum { get; set; }
        public int AnimeID { get; set; }
       
        public Animeler animeler { get; set; }
    }
}
