using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
       
  public  class CustomerEmployeeRepository :BaseRepository<CustomerEmployee>
    {
        TaskManagementContext _context;
        public CustomerEmployeeRepository(TaskManagementContext context) : base(context)
        {
            _context = context;
        }

        public List<CustomerEmployee> GetCusEmpByCustomerId(int customerId)
        {
            return _context.CustomerEmployees.Where(ce => ce.CustomerID == customerId).ToList();
        }


    }
}
