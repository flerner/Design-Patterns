using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShipCreator shipCreator = new ShipCreator();
            TruckCreator truckCreator = new TruckCreator();

            //we have a parent bstract class (Creator) and the child classes for creating an object of each type
            //we also have an Interface that every transport share, so we can store our instances of the objects in variables of type Product

            Product p = shipCreator.CreateTransport();
            p.TransportProduct();
            Product p2 = truckCreator.CreateTransport(); 
            p2.TransportProduct();

            Console.ReadKey();
        }
    }
}
