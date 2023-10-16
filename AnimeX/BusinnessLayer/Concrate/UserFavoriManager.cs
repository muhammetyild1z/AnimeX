using AnimeX.BusinnessLayer.Abstract;
using AnimeX.DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.BusinnessLayer.Concrate
{
    public class UserFavoriManager : IUserFavoriService
    {
        IUserFavoriDal _userFavoriDal;

        public UserFavoriManager(IUserFavoriDal userFavoriDal)
        {
            _userFavoriDal = userFavoriDal;
        }

        public void Delete(UserFavori entity)
        {
            _userFavoriDal.Delete(entity);  
        }

        public List<UserFavori> FavoriUserAnimelerGetListInclude()
        {
           return _userFavoriDal.FavoriUserAnimelerGetListInclude();
        }

        public UserFavori GetByID(int id)
        {
            return _userFavoriDal.GetByID(id);
        }

        public List<UserFavori> GetList()
        {
            return _userFavoriDal.GetList();
        }

        public List<UserFavori> GetListAllByIdInclude(Expression<Func<UserFavori, bool>> filter)
        {
           return _userFavoriDal.GetListAllByIdInclude(filter);
        }

        public void Insert(UserFavori entity)
        {
            _userFavoriDal.Insert(entity);
        }

        public void Update(UserFavori entity, UserFavori unchanged)
        {
            _userFavoriDal.Update(entity, unchanged);
        }
    }
}
