using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CustomerEmployee
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? CustomerID { get; set; }

        public string Phone { get; set; }

        // NAV PROP
        public virtual Customer Customer { get; set; }
    }
}