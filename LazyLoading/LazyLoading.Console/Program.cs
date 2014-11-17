using LazyLoading.Model;
using LazyLoading.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyLoading.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid customerId = Guid.NewGuid();

            IOrderRepository orderRepository = new OrderRepository();

            Customer customer = new CustomerProxy() { OrderRepository = orderRepository, Id = customerId };

            IEnumerable<Order> orders = customer.Orders;


        }
    }
}
