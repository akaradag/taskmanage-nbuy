using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RequestType
    {
        public RequestType()
        {
            Requests = new HashSet<Request>();
        }
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
