using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LazyLoading.Model;

namespace LazyLoading.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> FindAllBy(Guid customerId)
        {
            IEnumerable<Order> customerOrders = new List<Order>() { 
              new Order(){ Id=Guid.Parse("17DCABA2-1936-4321-8604-8861472C808A"), OrderDate=DateTime.Now},
               new Order(){ Id=Guid.Parse("DCD80C94-690E-49CA-AF4E-6890F40C2353"), OrderDate=DateTime.Now},
                new Order(){ Id=Guid.Parse("69048674-FD3B-4D39-8EFC-ED3ABC57B8C7"), OrderDate=DateTime.Now},
                 new Order(){ Id=Guid.Parse("F24E33FB-B2A7-4C73-A123-B564C195A47A"), OrderDate=DateTime.Now},
                  new Order(){ Id=Guid.Parse("FE2A5189-4705-4FEF-8EBC-D660DE87262A"), OrderDate=DateTime.Now}
            };

            return customerOrders;
        }
    }
}
