using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteCollection : Collection
    {
        private List<Item>_items = new List<Item>();
        private Item _item;
        private int _position;

        
        public override void Add(Item _item)
        {
            _items.Add(_item);
        }

        public override int Count()
        {
            return _items.Count;
        }

        public override IteratorExample CreateIterator()
        {
            return new ConcreteIteratorExample(this);
        }

        public override Item Index(int _index)
        {
            _item = _items[_index];
            _position = _index;
            return _item;
        }

        public override int Position()
        {
            return this._position;
        }
    }
}
