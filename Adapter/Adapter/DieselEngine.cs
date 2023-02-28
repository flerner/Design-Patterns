using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class DieselEngine : Engine
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating diesel engine");
        }

        public override void Refuel()
        {
            Console.WriteLine("Refueling diesel engine");
        }

        public override void StartUp()
        {
            Console.WriteLine("Starting up diesel engine");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping diesel engine");
        }
    }
}
