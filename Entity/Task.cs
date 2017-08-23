using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Task
    {
        public Task()
        {
            TaskLogs = new HashSet<TaskLog>();
        }

        public int ID { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        // İşin dahil olduğu proje
        public int ProjectID { get; set; }

        // NAV PROP

        public virtual ICollection<TaskLog> TaskLogs { get; set; }

        public virtual Project Project { get; set; }
    }
}
