using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.Abstract
{
    public interface IGenericDal<T>  where T : class 
    {
        void Insert(T entity);
        void Update(T entity, T unchanged);
        void Delete(T entity);
        T GetByID(int id);
        List<T> GetList();
        List<T> GetListAllByIdInclude(Expression<Func<T, bool>> filter);
    }
}
