using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserFavori
    {
        public int UserFavoriID { get; set; }
        public int UserFavAnimeID { get; set; }
       public Animeler animeler { get; set; }
        
        public int UserFavUserID { get; set; }
        public AppUser appUser { get; set; }
    }
}
