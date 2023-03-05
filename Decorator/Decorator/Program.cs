using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Felix", "1");

            IBankAccount salaryAccount = new SalaryAccount();
            IBankAccount blindageDecorator = new BlindageDecorator(salaryAccount);

            blindageDecorator.OpenAccount(account);

            Console.ReadKey();
        }
    }
}
