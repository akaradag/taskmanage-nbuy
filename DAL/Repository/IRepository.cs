using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    interface IRepostory<TEntity>
    {
        void Add(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
        List<TEntity> GetAll();
        TEntity Get(int id);
    }
}
