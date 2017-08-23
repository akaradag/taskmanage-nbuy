using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repository
{
    public class TaskStatusRepository : BaseRepository<Entity.TaskStatus>
    {
        TaskManagementContext _context;
        public TaskStatusRepository(TaskManagementContext context)
            : base(context)
        {
            this._context = context;
        }

        public Entity.TaskStatus GetLastStatusOfTask(int taskId)
        {
            Entity.TaskStatus taskStat = _context.TaskLogs.Where(tl => tl.TaskID == taskId).OrderByDescending(tl => tl.ID).FirstOrDefault().TaskStatus;

            return taskStat;
        }
    }
}
