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
    public class CategoryAnimeManeger : ICategoryAnimeService
    {
        ICategoryAnimeDal _categoryAnimeDal;

        public CategoryAnimeManeger(ICategoryAnimeDal categoryAnimeDal)
        {
            _categoryAnimeDal = categoryAnimeDal;
        }

        public List<CategoryAnime> GetCategoriesIncludecategoryAnime()
        {
           return _categoryAnimeDal.GetCategoriesIncludecategoryAnime();
        }

        public void TDelete(CategoryAnime entity)
        {
            _categoryAnimeDal.Delete(entity);
        }

        public CategoryAnime TGetByID(int id)
        {
            return  _categoryAnimeDal.GetByID(id);
        }

        public List<CategoryAnime> TGetList()
        {
           return _categoryAnimeDal.GetList();
        }

        public void TInsert(CategoryAnime entity)
        {
            _categoryAnimeDal.Insert(entity);
        }

        public void TUpdate(CategoryAnime entity, CategoryAnime unchanged)
        {
            _categoryAnimeDal.Update(entity, unchanged);
        }
    }
}
