using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class NormalFactory : AbstractFactory
    {
        public Ship CreateShip()
        {
            return new NormalShip();
        }

        public Truck CreateTruck()
        {
            return new NormalTruck();
        }
    }
}
