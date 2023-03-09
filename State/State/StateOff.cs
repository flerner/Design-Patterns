using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StateOff : State
    {

       

        public override void ControllState(Switch sw)
        {
            sw.SetState(new StateOn());
        }

        public override string Describe()
        {
            return "Current State: " + this.GetType().Name;
        }
    }
}
