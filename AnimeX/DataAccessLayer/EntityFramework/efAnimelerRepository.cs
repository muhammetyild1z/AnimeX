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
    public class efAnimelerRepository : GenericRepository<Animeler>, IAnimelerDal
    {
        public efAnimelerRepository(Context context) : base(context)
        {
        }

        public List<Animeler> GetCategoriesIncludeAnimeler()
        {
           Context c =new Context();
            return c.Animelers.Include(x=>x.categoryAnimes).ToList();
        }

        public List<Animeler> GetCommentIncludeAnimeler()
        {
            Context c = new Context();
            return c.Animelers.Include(x => x.comments).ToList();
        }
    }
}
