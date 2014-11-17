using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdentityMap.Model
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("Id:{0},FirstName:{1},LastName:{2}",Id,FirstName,LastName);
        }
    }
}
