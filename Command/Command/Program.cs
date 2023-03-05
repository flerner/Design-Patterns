using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyInvoker company = new CompanyInvoker();
            ProductReceiver product = new ProductReceiver();
            product.Amount = 100;

            var addCommand = new AddStockCommand(product, 10);
            var removeCommand = new RemoveStockCommand(product, 50);

            company.TakeOrder(addCommand);
            company.TakeOrder(removeCommand);

            company.ProcessOrders();
            Console.WriteLine("Stock remaining: " + product.Amount);

            Console.ReadKey();
        }
    }
}
