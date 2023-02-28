using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Remote
    {
        Device device;
        public Remote(Device device)
        {
            this.device = device;
        }
        public Device Device
        {
            set { this.device = value; }
        }
        public void TogglePower()
        {
            if (device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }
        public void ChannelUp()
        {
            int old = device.GetChannel();
            device.SetChannel(old+1);
        }
        public void SetVolume()
        {
            
           int old = device.GetVolume();
            device.SetVolume(old+1);
        }
    }
}
