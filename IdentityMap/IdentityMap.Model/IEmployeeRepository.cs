using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdentityMap.Model
{
    public interface IEmployeeRepository
    {
        Employee FindBy(Guid id);
    }
}
