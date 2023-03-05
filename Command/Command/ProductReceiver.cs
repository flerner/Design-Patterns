using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ProductReceiver
    {
        //the product itself knows how to add or remove stock, but the entity who call this methods are not the client directly, but instead the command, so the client
        //depends on an abstraction instead of the concrete product.
        public double Amount { get; set; }
        public string Name { get; set; }

        public void RemoveStock(double cant)
        {
            Amount -= cant;
            Console.WriteLine("Removing " + cant + " of the amount");
        }
        public void AddStock(double cant)
        {
            Amount+= cant;
            Console.WriteLine("Adding " + cant + " of the amount");
        }


    }
}
