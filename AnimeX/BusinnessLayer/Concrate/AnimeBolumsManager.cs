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
    public class AnimeBolumsManager : IAnimeBolumsService
    {
        IAnimeBolumsDal _animeBolums;

        public AnimeBolumsManager(IAnimeBolumsDal animeBolums)
        {
            _animeBolums = animeBolums;
        }

        public void TDelete(AnimeBolums entity)
        {
            _animeBolums.Delete(entity);
        }

        public AnimeBolums TGetByID(int id)
        {
            return _animeBolums.GetByID(id);
        }

        public List<AnimeBolums> TGetList()
        {
            return _animeBolums.GetList();
        }

        public List<AnimeBolums> TGetListIncludeBolumler()
        {
            return _animeBolums.GetListIncludeBolumler();
        }

        public void TInsert(AnimeBolums entity)
        {
            _animeBolums.Insert(entity);
        }

        public void TUpdate(AnimeBolums entity, AnimeBolums unchanged)
        {
            _animeBolums.Update(entity, unchanged); 
        }
    }
}
