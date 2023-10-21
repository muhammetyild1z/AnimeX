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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comments> CommentAnimelerInclude()
        {
            return _commentDal.CommentAnimelerInclude();
        }

        public List<Comments> CommentUserAndAnimeInclude()
        {
           return _commentDal.CommentUserAndAnimeInclude();
        }

        public List<Comments> CommentUserInclude()
        {
            return _commentDal.CommentUserInclude();
        }

        public void TDelete(Comments entity)
        {
            _commentDal.Delete(entity);
        }

        public Comments TGetByID(int id)
        {
          return _commentDal.GetByID(id);
        }

        public List<Comments> TGetList()
        {
            return _commentDal.GetList();
        }

        public void TInsert(Comments entity)
        {
            _commentDal.Insert(entity);
        }

        public void TUpdate(Comments entity, Comments unchanged)
        {
            _commentDal.Update(entity, unchanged); 
        }
    }
}
