using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we could construct this with Builder pattern 
            Device device;
            device = new Tv();
            Remote remote = new Remote(device);

            //client works only with abstraction, in this case, abstraction is Remote and implementation are the devices
            
            Client felix = new Client(remote);
            felix.TogglePower();
            felix.ChannelUp();
            felix.TogglePower();

            device = new Radio();
            remote.Device = device;
            felix.TogglePower();
            felix.SetVolume();
            felix.TogglePower();

            Console.ReadKey();
        }
    }
}
