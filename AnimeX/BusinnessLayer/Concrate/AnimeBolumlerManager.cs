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
    public class AnimeBolumlerManager : IAnimeBolumlerService
    {
        IAnimeBolumlerDal _animeBolumDal;

        public AnimeBolumlerManager(IAnimeBolumlerDal animeBolumDal)
        {
            _animeBolumDal = animeBolumDal;
        }

        public void TDelete(AnimeBolumler entity)
        {
            _animeBolumDal.Delete(entity);
        }

        public AnimeBolumler TGetByID(int id)
        {
            return _animeBolumDal.GetByID(id);
        }

        public List<AnimeBolumler> TGetList()
        {
            return _animeBolumDal.GetList();
        }

        public void TInsert(AnimeBolumler entity)
        {
            _animeBolumDal.Insert(entity);  
        }

        public void TUpdate(AnimeBolumler entity, AnimeBolumler unchanged)
        {
            _animeBolumDal.Update(entity, unchanged);
        }
    }
}
