using AnimeX.BusinnessLayer.Abstract;
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.EntityLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.BusinnessLayer.Concrate
{
    public class AnimeSezonManager : IAnimeSezonService
    {
        IAnimeSezonDal _sezonDal;

        public AnimeSezonManager(IAnimeSezonDal sezonDal)
        {
            _sezonDal = sezonDal;
        }

        public void TDelete(AnimeSezon entity)
        {
            _sezonDal.Delete(entity);
        }
        public AnimeSezon TGetByID(int id)
        {
          return _sezonDal.GetByID(id);
        }

        public List<AnimeSezon> TGetList()
        {
         return _sezonDal.GetList();
        }

        public void TInsert(AnimeSezon entity)
        {
                _sezonDal.Insert(entity);
        }

        public void TUpdate(AnimeSezon entity, AnimeSezon unchanged)
        {
                _sezonDal.Update(entity, unchanged);
        }
    }
}
