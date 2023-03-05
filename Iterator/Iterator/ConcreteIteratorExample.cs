using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteIteratorExample : IteratorExample
    {
        private Collection _aggregate;
        private Item _item;

        public ConcreteIteratorExample(Collection aggregate)
        {
            _aggregate = aggregate;
        }

        public override Item CurrentItem()
        {
            return _item;
        }

        public override void First()
        {
            _item = _aggregate.Index(0);
        }

        public override bool IsDone()
        {
            if(_aggregate.Count() == _aggregate.Position() + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Next()
        {
            _item = _aggregate.Index(_aggregate.Position() + 1);
        }
    }
}
