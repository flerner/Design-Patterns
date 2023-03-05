using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SavingAccount : IBankAccount
    {
        public void OpenAccount(Account account)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("A saving account has been opened");
            Console.WriteLine("Client: " + account.Client);
        }
    }
}
