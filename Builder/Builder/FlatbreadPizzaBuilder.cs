using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FlatbreadPizzaBuilder : PizzaBuilder
    {
        public FlatbreadPizzaBuilder() { _description = "Flatbread Pizza"; }
        public override Dough BuildDough()
        {
            return new Flatbread();
        }

        public override Sauce BuildSauce()
        {
            return new Pesto();
        }

        public override Topping BuildTopping()
        {
            return new Onion();
        }
    }
}
