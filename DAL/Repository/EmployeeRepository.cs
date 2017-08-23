using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        TaskManagementContext _context;
        public EmployeeRepository(TaskManagementContext context)
            : base(context)
        {
            _context = context;
        }

        public Employee GetByLogIn(string email, string password)
        {
            Employee emp = _context.Employees.Where(e => (e.Email == email && e.Password == password)).SingleOrDefault();

            return emp;
        }
        public List<Employee> GetByRole(int roleId)
        {
            List<Employee> empList = _context.Employees.Where(e => e.RoleID == roleId).ToList();
            return empList;
        }
        public Employee GetByTaskId(int taskId)
        {
            Employee emp = _context.TaskLogs.Where(tl => tl.TaskID == taskId).OrderByDescending(tl => tl.ID).FirstOrDefault().Employee;
            //object query = (from tl in _context.TaskLogs
            //              where tl.TaskID == taskId
            //              orderby tl.TaskDate
            //              select tl.EmployeeID).LastOrDefault();
            //Employee emp= new Employee();
            //int empId = 0;
            //if (int.TryParse(query.ToString(),out empId))
            //{
            //    emp = _context.Employees.Where(e => e.ID == empId).SingleOrDefault();
            //}

            return emp;
        }
    }
}
