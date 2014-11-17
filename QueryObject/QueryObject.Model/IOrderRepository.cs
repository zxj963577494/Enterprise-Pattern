using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueryObject.Infrastructure;

namespace QueryObject.Model
{
    public interface IOrderRepository
    {       
         IEnumerable<Order> FindBy(Query query);
         IEnumerable<Order> FindBy(Query query, int index, int count);         
    }
}
