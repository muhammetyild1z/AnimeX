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
    public class efAnimeBolumsRepository : GenericRepository<AnimeBolums>, IAnimeBolumsDal
    {
        public efAnimeBolumsRepository(Context context) : base(context)
        {
        }

        public List<AnimeBolums> GetListIncludeBolumler()
        {
            Context c = new Context();
            return c.AnimeBolums.Include(x => x.animeler).ToList();
        }
    }
}
