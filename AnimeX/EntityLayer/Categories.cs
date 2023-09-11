using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Categories
    {
        [Key]
        public int kategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public bool Status { get; set; }


       public List<CategoryAnime> categoryAnimes { get; set; }

    }
}
