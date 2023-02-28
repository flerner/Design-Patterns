using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class CarPrototype : Cloneable
    {
        protected string _color;
        protected string _model;

        public string Color { get { return _color; } set { _color = value; } }
        public string Model { get { return _model;} set { _model = value; } }

        public abstract Cloneable Clone();
        public abstract string WatchCar();
       
    }
}
