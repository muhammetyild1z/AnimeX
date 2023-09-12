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
    public class CategoriesManager : ICategoriesService
    {
        ICategoriesDal _categoriesDal;

        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal = categoriesDal;
        }

        public List<Categories> GetListCategoies()
        {
            return _categoriesDal.GetListCategoies();
        }

        public void TDelete(Categories entity)
        {
            _categoriesDal.Delete(entity);
        }

        public  Categories TGetByID(int id)
        {
           return  _categoriesDal.GetByID(id);
        }

        public  List<Categories> TGetList()
        {
           return _categoriesDal.GetList();
        }

        public void TInsert(Categories entity)
        {
            _categoriesDal.Insert(entity);
        }

        public void TUpdate(Categories entity, Categories unchanged)
        {
            _categoriesDal.Update(entity, unchanged);
        }
    }
}
