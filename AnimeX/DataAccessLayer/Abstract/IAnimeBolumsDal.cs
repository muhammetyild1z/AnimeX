using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.Abstract
{
    public interface IAnimeBolumsDal:IGenericDal<AnimeBolums>

    {
        List<AnimeBolums> GetListIncludeBolumler();
    }
}
