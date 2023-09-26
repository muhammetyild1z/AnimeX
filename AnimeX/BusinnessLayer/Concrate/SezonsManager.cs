using AnimeX.BusinnessLayer.Abstract;
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.BusinnessLayer.Concrate
{
    public class SezonsManager : ISezonsService
    {
        ISezonsDal _SezonsDal;

        public SezonsManager(ISezonsDal sezonsDal)
        {
            _SezonsDal = sezonsDal;
        }

        public void TDelete(Sezons entity)
        {
            _SezonsDal.Delete(entity);
        }

        public Sezons TGetByID(int id)
        {
           return _SezonsDal.GetByID(id);
        }

        public List<Sezons> TGetList()
        {
           return _SezonsDal.GetList();
        }

        public void TInsert(Sezons entity)
        {
            _SezonsDal.Insert(entity);
        }

        public void TUpdate(Sezons entity, Sezons unchanged)
        {
            _SezonsDal.Update(entity, unchanged);
        }
    }
}
