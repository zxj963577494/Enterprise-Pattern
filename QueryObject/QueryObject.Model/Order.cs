using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryObject.Model
{
    public class Order
    {
        public int Id { get; set; }
        public bool HasShipped { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid CustomerId { get; set; }
    }
}
