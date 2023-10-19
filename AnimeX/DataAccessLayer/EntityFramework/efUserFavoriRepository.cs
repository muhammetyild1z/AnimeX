using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.EntityFramework
{
    public class efUserFavoriRepository : GenericRepository<UserFavori>, IUserFavoriDal
    {
        public efUserFavoriRepository(Context context) : base(context)
        {
        }

        public List<UserFavori> FavoriUserAnimelerGetListInclude()
        {
            Context c = new Context();
            return c.userFavoris.Include(x => x.Animelers).Include(x=>x.AppUser).ToList();
        }
    }
}
