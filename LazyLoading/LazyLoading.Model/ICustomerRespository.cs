using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyLoading.Model
{
    public interface ICustomerRespository
    {
        Customer FindBy(Guid id);
    }
}
