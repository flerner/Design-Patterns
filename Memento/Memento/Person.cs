using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Person
    {
        public string Name { get; set; }

        public Memento SaveMemento()
        {
            Console.WriteLine("Originator: Saving memento for " + Name);
            return new Memento(Name);
        }

        public void RestoreMemento(Memento memento)
        {
            Name = memento.State;
            Console.WriteLine("Restoring memento to " + memento.State);
        }
    }
}
