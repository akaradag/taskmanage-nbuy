using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
  public  class RequestRepository:BaseRepository<Request>
    {
        TaskManagementContext _context;
        public RequestRepository(TaskManagementContext context):base(context)
        {
            _context = context;
        }

        public List<Entity.Request> GetAllByProjectID(int projectId)
        {
            return _context.Requests.Where(t => t.ProjectID == projectId).ToList();
        }

        public List<Entity.Request> GetAllFiltered(string input)
        {
            return _context.Requests.Where(t => t.Description.Contains(input)).ToList();
        }
    }
}
