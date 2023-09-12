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

        public AnimelerManager(IAnimelerDal animelerdal)
        {
                _animelerDal= animelerdal;
        }

        public void TDelete(Animeler entity)
        {
            _animelerDal.Delete(entity);
        }

        public Task<Animeler> TGetByIDAsync(int id)
        {
            return _animelerDal.GetByIDAsync(id);
        }

        public Task<List<Animeler>> TGetListAsync()
        {
            return _animelerDal.GetListAsync();
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
