using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.EntityFramework
{
    public class efCategoryAnimeRepository : GenericRepository<CategoryAnime>, ICategoryAnimeDal
    {
        public efCategoryAnimeRepository(Context context) : base(context)
        {
           
        }
        public List<CategoryAnime> GetCategoriesIncludecategoryAnime()
        {
            Context c = new Context();
            return c.CategoryAnimes.Include(x => x.categories).ToList();
        }
    }
}
