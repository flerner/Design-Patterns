using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        private string _name;

        public Component(string name)
        {
            _name = name;
        }
        public string Name
        {
            get { return _name; }
        }

        public abstract void AddChildren(Component child);
        public abstract IList<Component> GetChildren();
        public abstract int GetSize();
        
    }
}
