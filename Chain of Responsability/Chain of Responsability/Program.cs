using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Chain_of_Responsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this simulate the client

            Approver buyer = new Buyer();
            Approver manager = new Manager();
            Approver director = new Director();

            buyer.AddNext(manager);
            manager.AddNext(director);

            Purchase p = new Purchase();
            Console.WriteLine("Enter the total of your purchase");
            int total = -1;
            do
            {
                var line = Console.ReadLine();

                try
                {
                    total = int.Parse(line);
                    p.Amount = total;
                    buyer.Process(p);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } while (total != 0);

            Console.ReadKey();
        }
    }
}
