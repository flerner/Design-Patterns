using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine dieselEngine = new DieselEngine();
            dieselEngine.StartUp();
            dieselEngine.Accelerate();
            dieselEngine.Stop();
            dieselEngine.Refuel();

            Engine gasolineEngine = new GasolineEngine();
            gasolineEngine.StartUp();
            gasolineEngine.Accelerate();
            gasolineEngine.Stop();
            gasolineEngine.Refuel();

            Engine electricEngineAdapter = new ElectricEngineAdapter(new ElectricEngine());
            electricEngineAdapter.StartUp();
            electricEngineAdapter.Stop();
            electricEngineAdapter.Refuel();
            electricEngineAdapter.Accelerate();

            Console.ReadKey();
        }
    }
}
