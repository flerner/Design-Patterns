using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class GasolineEngine : Engine
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating gasoil engine");
        }

        public override void Refuel()
        {
            Console.WriteLine("Refueling gasoil engine");
        }

        public override void StartUp()
        {
            Console.WriteLine("Starting up gasoil engine");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping gasoil engine");
        }
    }
}
