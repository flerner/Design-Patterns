using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public abstract class Engine
    {
        public abstract void Accelerate();
        public abstract void StartUp();
        public abstract void Stop();
        public abstract void Refuel();
    }
}
