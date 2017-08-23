using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Request
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public DateTime RecievedDate { get; set; }

        public int? RequestTypeID { get; set; }

        public int? ProjectID { get; set; }

        // NAV PROP
        public virtual Project Project { get; set; }

        public virtual RequestType RequestType { get; set; }
    }
}
