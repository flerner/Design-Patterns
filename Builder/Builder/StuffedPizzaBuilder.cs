using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class StuffedPizzaBuilder : PizzaBuilder
    {
        public StuffedPizzaBuilder() { _description = "Stuffed pizza"; }
        public override Dough BuildDough()
        {
            return new Stuffed();
        }

        public override Sauce BuildSauce()
        {
            return new Tomatoes();
        }

        public override Topping BuildTopping()
        {
            return new Anchovies();
        }
    }
}
