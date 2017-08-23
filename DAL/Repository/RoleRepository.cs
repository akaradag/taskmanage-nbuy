using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
  public  class RoleRepository:BaseRepository<Role>
    {
        public RoleRepository(TaskManagementContext context):base(context)
        {

        }
    }
}
