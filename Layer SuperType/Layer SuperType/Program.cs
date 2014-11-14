using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layer_SuperType
{
    /*
     * 模式意图
     * Layer Supertype（层超类型）模式定义了一个对象，该对象充当自己所在层的所有类型的基类，而且采用类继承机制实现。
     * 例如，当某层中的所有对象共享一组公共的 业务逻辑时，可以使用Layer Supertype模式来移除重复的逻辑并将逻辑集中起来 
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(Guid.NewGuid());
            p.IsValid();
            
            Console.Read();

            Product p1 = new Product(Guid.NewGuid());
            p1.Id = Guid.NewGuid();
            Console.Read();
        }
    }
}
