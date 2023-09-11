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
        [Key]
        public int ID { get; set; }
        public int AnimeID { get; set; }

        public int KategoriID { get; set; }


        public List<Categories> categories { get; set; }
        public List<Animeler> animelers { get; set; }

    }
}
