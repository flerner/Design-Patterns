using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class CargoFactory : AbstractFactory
    {
        public Ship CreateShip()
        {
            return new CargoShip();
        }

        public Truck CreateTruck()
        {
            return new CargoTruck();
        }
    }
}
