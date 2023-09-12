using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.Repositories;
using EntityLayer;
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
    }
}
