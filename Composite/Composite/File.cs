using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class File : Component
    {
        private int _size;
        public File(int size, string name): base(name) 
        {
            _size = size;
        }
        //this two methods break the Interface Segregation principle of solid, but in this case, the pros are way better than this con
        public override void AddChildren(Component child)
        {
            throw new NotImplementedException();
        }

        public override IList<Component> GetChildren()
        {
            throw new NotImplementedException();
        }

        public override int GetSize()
        {
            return this._size;
        }
    }
}
