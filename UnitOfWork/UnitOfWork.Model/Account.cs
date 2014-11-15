using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitOfWork.Infrastructure;

namespace UnitOfWork.Model
{
    public class Account : IAggregateRoot
    {
        public Account(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance { get; set; }
    }
}
