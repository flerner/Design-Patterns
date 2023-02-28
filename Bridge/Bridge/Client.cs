using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Client
    {
        Remote _remote;
        public Client(Remote remote)
        {
            this._remote = remote;
        }
        public Remote Remote
        {
            set { this._remote = value; }
        }
        public void TogglePower()
        {
            _remote.TogglePower();
        }
        public void ChannelUp()
        {
            _remote.ChannelUp();
        }
        public void SetVolume()
        {
            _remote.SetVolume();
        }
        
    }
}
