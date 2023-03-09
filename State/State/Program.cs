using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch _switch= new Switch();
            _switch.Press();
            _switch.Press();
            _switch.Press();
            _switch.Press();
            _switch.Press();
            Console.ReadKey();
        }
    }
}
