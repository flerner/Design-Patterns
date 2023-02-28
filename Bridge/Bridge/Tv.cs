using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Tv : Device
    {
        private int _channel;
        private bool _enabled;

        public int Volume
        {
            get { return _channel; }
        }
        public bool Enabled
        {
            get { return _enabled; }
        }

      
        public bool IsEnabled()
        {
            return _enabled;
        }

        public void Enable()
        {
            Console.WriteLine("TV power on");
            this._enabled = true;
        }

        public void Disable()
        {
            Console.WriteLine("Tv power off");
            this._enabled = false;
        }

        public int GetVolume()
        {
            //this breaks with solid principle, is implementing an interface where not all methods are required, because tv does not have volume

            throw new NotImplementedException();
        }

        public void SetVolume(int volume)
        {
            //this breaks with solid principle, is implementing an interface where not all methods are required, because tv does not have volume

            throw new NotImplementedException();
        }

        public int GetChannel()
        {
            return this._channel;
        }

        public void SetChannel(int channel)
        {
            this._channel= channel;
            Console.WriteLine("Channel setted to " + channel);
        }
    }
}
