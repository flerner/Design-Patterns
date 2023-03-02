using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Felix");
            Customer c2 = new Customer("Lucas");
            CustomerRepository customerRepository = new CustomerRepository();
            CustomerRepositoryProxy customerRepositoryProxy = new CustomerRepositoryProxy(customerRepository);


            Client client = new Client();

            //an example class that the proxy class uses for checking if client has acces or not. The logic for checking this is not in the real class, but instead
            // is in the proxy class.
            Session.CanSave = true;
            Session.CanAcces = true;

            try
            {
                //client accesing CustomerRepository through Proxy class, using the IRepository interface
                client.Save(customerRepositoryProxy, c1);
                client.Save(customerRepositoryProxy, c2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            foreach (Customer customer in client.GetAll(customerRepositoryProxy))
            {
                Console.WriteLine(customer.Name);
            }

            Console.ReadLine();

            //we could also acces to the class directly but this would skip the security steps that the proxy class include

            foreach (Customer customer in client.GetAll(customerRepository))
            {
                Console.WriteLine(customer.Name);
            }

            Console.ReadLine();
        }
    }
}
