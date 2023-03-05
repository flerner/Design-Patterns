using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SalaryAccount : IBankAccount
    {
        public void OpenAccount(Account account)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("A salary account has been opened");
            Console.WriteLine("Client: " + account.Client);
        }
    }
}
