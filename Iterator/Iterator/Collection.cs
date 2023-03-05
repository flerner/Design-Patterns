using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public abstract class Collection
    {
        public abstract IteratorExample CreateIterator();
        public abstract void Add(Item _item);
        public abstract Item Index(int _index);
        public abstract int Count();
        public abstract int Position();
    }
}
