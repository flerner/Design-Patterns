using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
    public abstract class Approver
    {
        protected Approver _next;
        public void AddNext(Approver next)
        {
            _next = next;
        }
        public abstract void Process(Purchase p);
    }
}
