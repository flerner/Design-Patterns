using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Radio : Device
    {
        private int _volume;
        private bool _enabled;

        public int Volume
        {
            get { return _volume; }
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
            this._enabled= true;
            Console.WriteLine("Radio turned on");
        }

        public void Disable()
        {
            this._enabled= false;
            Console.WriteLine("Radio turned off");
        }

        public int GetVolume()
        {
            return this._volume;
        }

        public void SetVolume(int volume)
        {
            this._volume = volume;
            Console.WriteLine("Volume setted to " + volume);
        }

        public int GetChannel()
        {
            //this breaks with solid principle, is implementing an interface where not all methods are required, because radio does not have channels
            throw new NotImplementedException();
        }

        public void SetChannel(int channel)
        {
            //this breaks with solid principle, is implementing an interface where not all methods are required, because radio does not have channels
            throw new NotImplementedException();
        }
    }
}
