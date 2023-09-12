using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.BusinnessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T entity);
        void TUpdate(T entity, T unchanged);
        void TDelete(T entity);
        T TGetByID(int id);
        List<T> TGetList();
    }
}
