using QueryObject.Infrastructure;
using QueryObject.Model;
using QueryObject.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QueryObject.Console
{
    /*
     * 模式意图
     * Query Object模式的主要好处是完全将底层的数据库查询语言抽象出来，因此将
     * 数据持久化和检索的基础设施关注点从业务层中分离出来。但是有时候，需要创
     * 建原始的数据库查询语句。这可以通过使用数据库特有的QueryTranslator来实现
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            string sqlConnctionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\GitHub\Enterprise-Pattern\QueryObject\QueryObject.Console\QueryObjectDB.mdf;Integrated Security=True";
            IOrderRepository orderRepository = new OrderRepository(sqlConnctionString);
            OrderService orderService = new OrderService(orderRepository);

            IEnumerable<Order> orders;
            Guid customerId = new Guid("0A7EA4D0-0B1C-45C4-8C23-AEA41AB2F03E");

            orders = orderService.FindAllCustomersOrdersBy(customerId);

            foreach (Order order in orders)
            {
                System.Console.WriteLine("Id:{0},HasShipped:{1},OrderDate:{2},CustomerId:{3}", order.Id, order.HasShipped, order.OrderDate,order.CustomerId);
            }

            System.Console.ReadKey();



          
        }
    }
}
