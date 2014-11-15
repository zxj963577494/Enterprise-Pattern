using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitOfWork.Infrastructure;

namespace UnitOfWork.Model
{
    public class AccountService
    {
        private IAccountRepository _accountRepository;
        private IUnitOfWork _unitOfWork;

        public AccountService(IAccountRepository accountRepository,IUnitOfWork unitwork)
        {
            this._accountRepository = accountRepository;
            this._unitOfWork = unitwork;
        }

        public void Transfer(Account from, Account to, decimal amount)
        {
            if (from.Balance>=amount)
            {
                from.Balance -= amount;
                to.Balance += amount;

                _accountRepository.Save(from);
                _accountRepository.Save(to);
                _unitOfWork.Commit();
            }
        }
    }
}
