using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory;
            Ship ship;
            Truck truck;

            factory = new CargoFactory();

            ship = factory.CreateShip();
            truck = factory.CreateTruck();
            Console.WriteLine(ship.Description);
            Console.WriteLine(truck.Description);

            factory = new NormalFactory();

            ship = factory.CreateShip();
            truck = factory.CreateTruck();
            Console.WriteLine(ship.Description);
            Console.WriteLine(truck.Description);

            Console.ReadKey();
        }
    }
}
