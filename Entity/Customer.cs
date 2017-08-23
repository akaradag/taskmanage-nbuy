using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        public Customer()
        {

            this.Contacts = new HashSet<CustomerEmployee>();
            this.Projects = new HashSet<Project>();

        }
        public int ID { get; set; }

        public virtual ICollection<CustomerEmployee> Contacts { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

    }
}
