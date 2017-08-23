using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Project
    {
        public Project()
        {
            this.Tasks = new HashSet<Task>();
            this.Requests = new HashSet<Request>();

        }
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public ICollection<Request> Requests { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int? CustomerID { get; set; }

        // NAV PROP
        public virtual Customer Customer { get; set; }
    }
}
