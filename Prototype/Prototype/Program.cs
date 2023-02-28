using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cloneable audiPrototype = new AudiPrototype();
            Cloneable fiatPrototype = new FiatPrototype();

            CarPrototype audiA4 = (CarPrototype) audiPrototype.Clone();
            audiA4.Model = "A4";
            audiA4.Color = "Black";

            CarPrototype audiA5 = (CarPrototype)audiPrototype.Clone();
            audiA5.Model = "A5";
            audiA5.Color = "Red";

            Console.WriteLine(audiA4.WatchCar());
            Console.WriteLine(audiA5.WatchCar());

            CarPrototype fiatPalio = (CarPrototype)fiatPrototype.Clone();
            fiatPalio.Model = "Palio";
            fiatPalio.Color= "Green";

            CarPrototype fiatCronos = (CarPrototype)fiatPrototype.Clone();
            fiatCronos.Model = "Cronos";
            fiatCronos.Color = "Blue";

            Console.WriteLine(fiatPalio.WatchCar());
            Console.WriteLine(fiatCronos.WatchCar());

            //check if memory references are indeed different

            Console.WriteLine(fiatCronos == fiatPalio);
            Console.WriteLine(audiA4 == audiA5);

            Console.ReadKey();
        }
    }
}
