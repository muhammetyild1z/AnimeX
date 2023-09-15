using AnimeX.BusinnessLayer.Abstract;
using AnimeX.DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.BusinnessLayer.Concrate
{
    public class AnimelerManager : IAnimelerService
    {
        IAnimelerDal _animelerDal;

        public AnimelerManager(IAnimelerDal animelerDal)
        {
            _animelerDal = animelerDal;
        }

        public List<Animeler> GetAnimeAdiIncludeAnimeSezon()
        {
           return  _animelerDal.GetAnimeAdiIncludeAnimeSezon();
        }

        public void TDelete(Animeler entity)
        {
            _animelerDal.Delete(entity);
        }

        public Animeler TGetByID(int id)
        {
            return _animelerDal.GetByID(id);
        }

        public List<Animeler> TGetList()
        {
            return _animelerDal.GetList();
        }

        public void TInsert(Animeler entity)
        {
            _animelerDal.Insert(entity);
        }

        public void TUpdate(Animeler entity, Animeler unchanged)
        {
            _animelerDal.Update(entity, unchanged);
        }
    }
}
