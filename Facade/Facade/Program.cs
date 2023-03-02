using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Food app is the Facade, so the client only has to deal with that class, not knowing the inner logic of the main classes.
            DeliveryCompany deliveryCompany= new DeliveryCompany();
            Restaurant restaurant= new Restaurant();

            FoodApp foodApp = new FoodApp(deliveryCompany, restaurant);

            Client client = new Client();

            client.OrderFood(foodApp);

            Console.ReadKey();
        }
    }
}
