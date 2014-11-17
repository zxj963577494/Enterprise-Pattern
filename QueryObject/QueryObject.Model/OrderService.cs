using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueryObject.Infrastructure;

namespace QueryObject.Model
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> FindAllCustomersOrdersBy(Guid customerId)
        {
            IEnumerable<Order> customerOrders = new List<Order>();

            Query query = new Query();

            //字符串
            //query.Add(new Criterion("CustomerId", customerId, CriteriaOperator.Equal));

            //Lambda
            query.Add(Criterion.Createe<Order>(o => o.CustomerId, customerId, CriteriaOperator.Equal));

            query.OrderByProperty = new OrderByClause("CustomerId", true);

            customerOrders = _orderRepository.FindBy(query);


            return customerOrders;
        }

        public IEnumerable<Order> FindAllCustomersOrdersWithInOrderDateBy(Guid customerId, DateTime orderDate)
        {
            IEnumerable<Order> customerOrders = new List<Order>();

            Query query = new Query();
            query.Add(new Criterion("CustomerId", customerId, CriteriaOperator.Equal));
            query.QueryOperator = QueryOperator.And;
            query.Add(new Criterion("OrderDate", orderDate, CriteriaOperator.LessThanOrEqual));
            query.OrderByProperty = new OrderByClause("OrderDate", true);
            customerOrders = _orderRepository.FindBy(query);

            return customerOrders;
        }

        public IEnumerable<Order> FindAllCustomersOrdersUsingAComplexQueryWith(Guid customerId)
        {
            IEnumerable<Order> customerOrders = new List<Order>();

            Query query = NamedQueryFactory.CreateRetrieveOrdersUsingAComplexQuery(customerId);

            customerOrders = _orderRepository.FindBy(query);

            return customerOrders;
        }
    }
}
