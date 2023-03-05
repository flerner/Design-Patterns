using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AddStockCommand : OrderCommand
    {
        public AddStockCommand(ProductReceiver product, double amount) : base(product, amount)
        {
        }

        public override void Execute()
        {
            _product.AddStock(_amount);
        }
    }
}
