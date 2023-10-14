using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnimeBolums
    {
        [Key]
        public int BolumID { get; set; }
        public string BolumUrl { get; set; }
        public int BolumNo { get; set; }
        public int SezonsNo { get; set; }
        public int BolumAnimeID { get; set; }
        public DateTime BolumCreateDate { get; set; }
       
        public Animeler animeler { get; set; }


    }
}
