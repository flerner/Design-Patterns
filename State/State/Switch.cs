using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Switch
    {
        private State _state;

        public Switch() 
        {
            _state = new StateOn();
        }

        public void SetState(State state) 
        {
            _state = state;
        }

        public void Press()
        {
            _state.ControllState(this);
            Console.WriteLine(_state.Describe());
        }
    }
}
