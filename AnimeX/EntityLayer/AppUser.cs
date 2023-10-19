using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AppUser: IdentityUser<int>
    {
        public string UserImg { get; set; }
        public string Details { get; set; }
        public DateTime UserCreateDate { get; set; }
        public List<UserFavori> userFavoris { get; set; }
    }
}
