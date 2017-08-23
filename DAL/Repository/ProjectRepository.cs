using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
  public  class ProjectRepository:BaseRepository<Project>
    {
        public ProjectRepository(TaskManagementContext context):base(context)
        {

        }
    }
}
