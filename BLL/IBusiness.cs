﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IBusiness<TEntity>
    {
        bool Add(TEntity item);

        bool Remove(TEntity item);

        bool Update(TEntity item);

        List<TEntity> GetAll();

        TEntity Get(int id);
    }
}
