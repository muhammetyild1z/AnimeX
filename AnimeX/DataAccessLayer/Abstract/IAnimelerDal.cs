﻿using AnimeX.DataAccessLayer.Repositories;

using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeX.DataAccessLayer.Abstract
{
    public interface IAnimelerDal:IGenericDal<Animeler>
    {
        List<Animeler> GetCommentIncludeAnimeler();
        List<Animeler> GetCategoriesIncludeAnimeler();
    }
}
