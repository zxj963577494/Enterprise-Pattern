using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IdentityMap.Model;
using IdentityMap.Repository;

namespace IdentityMap.Console
{
    /*
     * 模式意图
     * IdentityMap模式"通过将所有已加载对象放在一个映射中确保所有对象只被加载一次"，
     * 并且"在引用这些对象时使用该映射来查找对象"。
     * 该模式提供了功能：
     * 为事务中使用的所有业务对象均保存一个版本 ，如果同一个对象实体请求两次，返回
     * 同一个实体。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.FindBy(Guid.Parse("56878860-9136-43B1-B188-A48D5E0E6655"));
            System.Console.WriteLine(employee.ToString());

            System.Console.ReadKey();
        }
    }
}
