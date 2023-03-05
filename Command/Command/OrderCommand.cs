using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class OrderCommand
    {
        protected ProductReceiver _product;
        protected double _amount;

        public abstract void Execute();
        public OrderCommand(ProductReceiver product, double amount)
        {
            _product = product;
            _amount = amount;
        }
    }
}
