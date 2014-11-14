using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layer_SuperType
{
    public class Customer : EntityBase<int>
    {
        public Customer()
        {

        }

        public Customer(int id):base(id)
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected override void CheckForBrokenRules()
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                base.AddBrokenRule("FirstName 不能为空");
            }

            if (string.IsNullOrEmpty(LastName))
            {
                base.AddBrokenRule("LastName 不能为空");
            }
        }
    }
}
