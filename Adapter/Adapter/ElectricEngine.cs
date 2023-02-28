using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ElectricEngine
    {
        bool _connected;
        bool _active;
        bool _moving;

        public void Connect()
        {
            if (_connected)
            {
                Console.WriteLine("Impossible to connect a connected engine...");
            }
            else
            {
                Console.WriteLine("Connecting Engine...");
                _connected = true;
            }
        }
        public void Activate()
        {
            if (_active)
            {
                Console.WriteLine("Impossible to activate an active engine...");
            }
            else
            {
                Console.WriteLine("Activating engine...");
                _active = true;
            }
        }

        public void Move()
        {
            if (_moving)
            {
                Console.WriteLine("Engine already moving...");
            }
            else
            {
                Console.WriteLine("Moving engine...");
                _moving = true;
            }
        }
        public void Stop()
        {
            if (_moving)
            {
                Console.WriteLine("Stopping engine");
                _moving = false;
            }
            else
            {
                Console.WriteLine("Engine already stopped");
            }
        }
        public void Dissconect()
        {
            if(_connected)
            {
                Console.WriteLine("Disconecting engine");
                _connected= false;
            }
            else
            {
                Console.WriteLine("Engine already discconected");
            }
        }
        public void Disactivate()
        {
            if(_active)
            {
                Console.WriteLine("Desactivating engine");
                _active=false;
            }
            else
            {
                Console.WriteLine("Already disactivated");
            }
        }
        public void Plug()
        {
            if (_active)
            {
                Console.WriteLine("Immposible to plug an active engine");
            }
            else
            {
                Console.WriteLine("Plugging in the engine");

            }
        }
    }
}
