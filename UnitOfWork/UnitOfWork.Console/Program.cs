using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitOfWork.Infrastructure;
using UnitOfWork.Model;
using UnitOfWork.Repository;

namespace UnitOfWork.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Account a = new Account(1000);
            System.Console.WriteLine("现在张三,存有{0}", a.Balance);
            Account b = new Account(200);
            System.Console.WriteLine("现在李四,存有{0}", b.Balance);
            System.Console.WriteLine("张三准备转500元给李四，转帐开始了......");

            //声明要使用的UnitOfWork
            IUnitOfWork unitOfWork = new UnitOfWork.Infrastructure.UnitOfWork();

            //声明要使用的Repository
            IAccountRepository accountRepository = new AccountRepository(unitOfWork);

            AccountService service = new AccountService(accountRepository, unitOfWork);

            service.Transfer(a, b, 500);
            System.Console.WriteLine("转账结束");
            System.Console.WriteLine("张三当前余额：{0}", a.Balance);
            System.Console.WriteLine("李四当前余额：{0}", b.Balance);

            System.Console.ReadKey();
        }
    }
}
