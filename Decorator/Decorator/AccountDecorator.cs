using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class AccountDecorator : IBankAccount
    {
        protected IBankAccount decoratedAccount;

        protected AccountDecorator(IBankAccount decoratedAccount)
        {
            this.decoratedAccount = decoratedAccount;
        }

        public virtual void OpenAccount(Account account)
        {
            this.decoratedAccount.OpenAccount(account);
        }
    }
}
