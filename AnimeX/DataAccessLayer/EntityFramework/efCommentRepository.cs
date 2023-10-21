using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.EntityFramework
{
    public class efCommentRepository : GenericRepository<Comments>, ICommentDal
    {
        public efCommentRepository(Context context) : base(context)
        {
        }

        public List<Comments> CommentAnimelerInclude()
        {
            Context c = new Context();
            return c.comments.Include(x => x.animeler).ToList();
        }

        public List<Comments> CommentUserAndAnimeInclude()
        {
            Context c = new Context();
            return c.comments.Include(x => x.appUser).Include(x=>x.animeler).ToList();
        }

        public List<Comments> CommentUserInclude()
        {
            Context c = new Context();
            return c.comments.Include(x => x.appUser).ToList();
        }
    }
}
