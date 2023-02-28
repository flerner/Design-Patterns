using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ElectricEngineAdapter : Engine
    {
        private readonly ElectricEngine _engine;

        public ElectricEngineAdapter(ElectricEngine engine)
        {
            _engine = engine;
        }
        public override void Accelerate()
        {

            _engine.Move();
        }

        public override void Refuel()
        {
            _engine.Plug();
        }

        public override void StartUp()
        {
            _engine.Connect();
            _engine.Activate();
        }

        public override void Stop()
        {
            _engine.Disactivate();
            _engine.Stop();
        }
    }
}
