using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer");
            this._observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer");
            this._observers.Remove(observer);
        }
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying all observers");
            foreach(IObserver observer in this._observers)
            {
                observer.Update(this);
            }
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: Im doing something important");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to " + this.State);
            this.Notify();
        }

    }
}
