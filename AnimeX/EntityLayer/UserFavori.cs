using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserFavori
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserFavoriID { get; set; }
        public int UserFavAnimeID { get; set; }
          public Animeler animeler { get; set; }
        
        public int UserFavUserID { get; set; }
        public AppUser appUser { get; set; }
    }
}
