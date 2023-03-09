using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class CareTaker
    {
        private List<Memento> _mementoList = new List<Memento>();

        public void Add(Memento memento)
        {
            _mementoList.Add(memento);
        }
        public Memento GetMemento(int idx)
        {
            return _mementoList[idx];
        }
    }
}
