using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public abstract class IteratorExample
    {
        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();

        public abstract Item CurrentItem();
    }
}
