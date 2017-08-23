using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TaskRepository : BaseRepository<Entity.Task>
    {
        TaskManagementContext _context;
        public TaskRepository(TaskManagementContext context)
            : base(context)
        {
            _context = context;
        }
        public List<Entity.Task> GetAllByProject(int projectId)
        {
            return _context.Tasks.Where(t => t.ProjectID == projectId).ToList();
        }
        public List<Entity.Task> GetAllFiltered(string filter)
        {
            return _context.Tasks.Where(t => t.Description.Contains(filter)).ToList();
        }
    }
}
