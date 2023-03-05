using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Item
    {
        public string Name { get; set; }
        public Item(string _name)
        {
            Name = _name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
