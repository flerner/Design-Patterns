using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsability
{
    public class Buyer : Approver
    {
        public const int AMOUNT = 100;
        public override void Process(Purchase p)
        {
            if (p.Amount < AMOUNT)
            {
                Console.WriteLine("Buy processed by " + this.GetType().Name);
            }
            else
            {
                _next.Process(p);
            }
        }
    }
}
