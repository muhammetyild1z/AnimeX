using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.Repositories;
using AnimeX.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.EntityFramework
{
    public class efSezonsRepository : GenericRepository<Sezons>, ISezonsDal
    {
        public efSezonsRepository(Context context) : base(context)
        {
        }
    }
}
