using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Felix";


            CareTaker careTaker = new CareTaker();
            careTaker.Add(p1.SaveMemento());

            p1.Name = "Felix1";
            careTaker.Add(p1.SaveMemento());

            p1.Name = "Felix2";
            careTaker.Add(p1.SaveMemento());

            Memento m1 = careTaker.GetMemento(0);
            Console.WriteLine("Viewing memento n°1 " + m1.State);
            Console.WriteLine("Viewing memento n°2 " + careTaker.GetMemento(1).State);
            Console.WriteLine("Viewing memento n°3 " + careTaker.GetMemento(2).State);


            //we can go back to a previous memento
            p1.RestoreMemento(m1);
            Console.WriteLine("Restored to first memento");
            Console.WriteLine(p1.Name);

            //any memento we want that is stored in the caretaker
            p1.RestoreMemento(careTaker.GetMemento(2));
            Console.WriteLine("Restored to last memento");
            Console.WriteLine(p1.Name);

            Console.ReadKey();
        }
    }
}
