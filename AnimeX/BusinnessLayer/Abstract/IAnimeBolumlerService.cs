using AnimeX.EntityLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.BusinnessLayer.Abstract
{
    public interface IAnimeBolumlerService:IGenericService<AnimeBolumler>
    {
        List<AnimeBolumler> GetListBolumler();
    }
}
