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
    public class AnimeSezon
    {
        [Key]
        public int ID { get; set; }     
        public int BolumNo { get; set; }      
        public string BolumIzleUrl { get; set; }
        public DateTime BolumCreateDate { get; set; }
        public Animeler AnimeID_Sezon { get; set; }
        public int SezonID{ get; set; }
        public List<Sezons> sezons { get; set; }
    }
}
