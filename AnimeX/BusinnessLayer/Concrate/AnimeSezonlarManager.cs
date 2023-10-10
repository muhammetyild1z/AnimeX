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
    public class AnimeSezonlarManager : IAnimeSezonlarService
    {
        IAnimeSezonlarDal _animeSezonlarDal;

        public AnimeSezonlarManager(IAnimeSezonlarDal animeSezonlarDal)
        {
            _animeSezonlarDal = animeSezonlarDal;
        }

        public void TDelete(AnimeSezonlar entity)
        {
            _animeSezonlarDal.Delete  (entity);
        }

        public AnimeSezonlar TGetByID(int id)
        {
            return _animeSezonlarDal.GetByID (id);
        }

        public List<AnimeSezonlar> TGetList()
        {
            return _animeSezonlarDal.GetList();
        }

        public void TInsert(AnimeSezonlar entity)
        {
            _animeSezonlarDal.Insert (entity);
        }

        public void TUpdate(AnimeSezonlar entity, AnimeSezonlar unchanged)
        {
            _animeSezonlarDal.Update (entity, unchanged);
        }
    }
}
