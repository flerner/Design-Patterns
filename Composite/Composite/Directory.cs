using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Directory : Component
    {
        private List<Component> _children;

        public Directory(string name): base(name)
        {
            this._children= new List<Component>();
        }
        public override void AddChildren(Component child)
        {
            this._children.Add(child);
        }

        public override IList<Component> GetChildren()
        {
            return this._children.ToArray();
        }

        public override int GetSize()
        {
            int total=0;
            foreach(Component child in this._children)
            {
                total += child.GetSize();
            }
            return total;
        }
    }
}
