using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine(this.GetType().Name + " reacted to the event");
            }
        }
    }
}
