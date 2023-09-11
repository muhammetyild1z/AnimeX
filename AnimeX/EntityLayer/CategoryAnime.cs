using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CategoryAnime
    {
        public int AnimeID { get; set; }
        public int KategoriID { get; set; }
        public List<Animeler> animelers { get; set; }   
        public List<Categories> categories { get; set; }   
    }
}
