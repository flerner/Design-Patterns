using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class BlindageDecorator : AccountDecorator
    {
        public BlindageDecorator(IBankAccount decoratedAccount) : base(decoratedAccount)
        {
        }
        public override void OpenAccount(Account account)
        {
            base.decoratedAccount.OpenAccount(account);
            AddBlindage();
        }

        private void AddBlindage()
        {
            Console.WriteLine("The account has been blindaged");
        }
    }
}
