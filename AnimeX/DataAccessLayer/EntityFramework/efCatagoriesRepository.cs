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
    public class efCatagoriesRepository : GenericRepository<Categories>, ICategoriesDal
    {
        public efCatagoriesRepository(Context context) : base(context)
        {
        }

        public List<Categories> GetListCategoies()
        {
            Context c = new Context();
            return  c.Categories.ToList();
        }
        
    }
}
