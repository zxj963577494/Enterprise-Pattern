using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IdentityMap.Model;

namespace IdentityMap.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private IdentityMap<Employee> _employeeMap;

        public EmployeeRepository()
        {
            _employeeMap = new IdentityMap<Employee>();
        }

        public Employee FindBy(Guid id)
        {
            Employee employee = _employeeMap.GetById(id);
            if (employee==null)
            {
                employee = DatastoreFindBy(id);
                if (employee!=null)
                {
                    _employeeMap.Store(employee.Id,employee);
                }
            }
            return employee;
        }

        private Employee DatastoreFindBy(Guid Id)
        {
            Employee employee = new Employee();

            employee.Id = Guid.Parse("56878860-9136-43B1-B188-A48D5E0E6655");
            employee.FirstName = "xv";
            employee.LastName = "z";

            return employee;
        }
    }
}
