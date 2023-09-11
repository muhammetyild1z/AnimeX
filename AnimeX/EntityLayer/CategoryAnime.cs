using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CategoryAnime
    {
        public int ID { get; set; }         
        public Animeler AnimeID { get; set; }
        public Categories KategoriID { get; set; }

    }
}
