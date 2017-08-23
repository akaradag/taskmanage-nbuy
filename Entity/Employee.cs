using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
        public Employee()
        {
            this.TaskLogs = new HashSet<TaskLog>();
        }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        public int? RoleID { get; set; }

        // NAV PROP

        // Çalışandaki işlerin listesi
        public ICollection<TaskLog> TaskLogs { get; set; }

        public virtual Role Role { get; set; }

        public string FullNameRole
        {
            get { return string.Format("{0} {1} - {2}", FirstName, LastName, Role.Name); }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
