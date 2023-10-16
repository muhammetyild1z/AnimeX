using AnimeX.DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.BusinnessLayer.Abstract
{
    public interface IUserFavoriService:IGenericDal<UserFavori>
    {
        List<UserFavori> FavoriUserAnimelerGetListInclude();
    }
}
