using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SicilianPizzaBuilder : PizzaBuilder
    {

        public SicilianPizzaBuilder() { _description = "Sicilian pizza"; }
        public override Dough BuildDough()
        {
            return new Sicilian();
        }

        public override Sauce BuildSauce()
        {
            return new FourCheese();
        }

        public override Topping BuildTopping()
        {
            return new OliveTomatoes();
        }
    }
}
