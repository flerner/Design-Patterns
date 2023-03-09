using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Memento
{
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }
        public Memento() { }
        public string State { get { return _state; } }

    }
}
