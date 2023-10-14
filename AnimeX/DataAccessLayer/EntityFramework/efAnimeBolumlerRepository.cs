using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.Repositories;
using AnimeX.EntityLayer;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.EntityFramework
{
    public class efAnimeBolumlerRepository : GenericRepository<AnimeBolumler>, IAnimeBolumlerDal
    {
        public efAnimeBolumlerRepository(Context context) : base(context)
        {
        }

        public List<AnimeBolumler> GetListBolumler()
        {
            throw new NotImplementedException();
        }

        //public List<AnimeBolumler> GetListBolumler()
        //{
        //    //Context c = new Context();
        //    //return c.animeBolumlers.Include(x=>x.Animelers).ToList();
        //}
    }
}
