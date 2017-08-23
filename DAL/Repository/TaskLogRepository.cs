using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TaskLogRepository : BaseRepository<TaskLog>
    {
        TaskManagementContext _context;
        public TaskLogRepository(TaskManagementContext context)
            : base(context)
        {
            _context = context;
        }
        public List<Entity.TaskLog> GetAllByProject(int projectId)
        {
            return _context.TaskLogs.Where(t => t.Task.ProjectID == projectId).ToList();
            //return (from tl in _context.TaskLogs
            //        join t in _context.Tasks on tl.TaskID equals t.ID
            //            where t.ProjectID == projectId
            //            select t).ToList()
        }
        public List<Entity.TaskLog> GetAllFiltered(string filter)
        {
            return _context.TaskLogs.Where(t => t.Task.Description.Contains(filter) || t.TaskStatus.Name.Contains(filter) || t.Employee.FirstName.Contains(filter) || t.Employee.LastName.Contains(filter)).ToList();
        }
        public List<Entity.TaskLog> GetAllByEmployeeID(int employeeID)
        {
            if (employeeID == -1)
            {
                return _context.TaskLogs.Where(t => t.EmployeeID == null).ToList();
            }
            return _context.TaskLogs.Where(t => t.EmployeeID == employeeID).ToList();
        }

        public Entity.TaskLog GetLastByTaskId(int taskId)
        {
            return _context.TaskLogs.Where(tl => tl.TaskID == taskId).OrderBy(tl => tl.TaskDate).LastOrDefault();
        }
    }
}
