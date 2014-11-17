using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LazyLoading.Model;

namespace LazyLoading.Repository
{
    public class CustomerRepository : ICustomerRespository
    {
        private IOrderRepository _orderRepository;

        public CustomerRepository(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Customer FindBy(Guid id)
        {
            Customer customer = new CustomerProxy();

            // Code to connect to the database and retrieve a customer

            ((CustomerProxy)customer).OrderRepository = _orderRepository; 
            
            return customer;
        }        
    }
}
