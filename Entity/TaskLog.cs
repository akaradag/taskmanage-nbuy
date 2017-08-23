using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TaskLog
    {
        public int ID { get; set; }

        public DateTime TaskDate { get; set; }

        public int? TaskID { get; set; }

        public int? TaskStatusID { get; set; }

        public int? EmployeeID { get; set; }

        // NAV PROP
        public virtual Task Task { get; set; }

        public virtual TaskStatus TaskStatus { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
