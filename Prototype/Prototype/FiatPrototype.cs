using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class FiatPrototype : CarPrototype
    {
        public override Cloneable Clone()
        {
            return (Cloneable) this.MemberwiseClone();
        }

        public override string WatchCar()
        {
            return $"Fiat {Model} color {Color}";
        }
    }
}
