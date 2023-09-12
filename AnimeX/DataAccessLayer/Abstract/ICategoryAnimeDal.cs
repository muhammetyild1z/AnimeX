using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.Abstract
{
    public interface ICategoryAnimeDal : IGenericDal<CategoryAnime>
    {
        List<CategoryAnime> GetCategoriesIncludecategoryAnime();
    }
}
