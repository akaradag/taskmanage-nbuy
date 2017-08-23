using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TaskStatus
    {
        public TaskStatus()
        {
            TaskLogs = new HashSet<TaskLog>();
        }
        public int ID { get; set; }

        public string Name { get; set; }

        //Nav prop

        public virtual ICollection<TaskLog> TaskLogs { get; set; }
    }
}
