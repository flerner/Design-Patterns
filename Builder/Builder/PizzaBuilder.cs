using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class PizzaBuilder
    {
        protected string _description;
        public abstract Dough BuildDough();
        public abstract Topping BuildTopping();
        public abstract Sauce BuildSauce();

        public override string ToString()
        {
            return _description;
        }

        public Pizza BuildPizza()
        {
            Dough dough= BuildDough();
            Topping topping = BuildTopping();
            Sauce sauce = BuildSauce();
            return new Pizza(dough, topping, sauce, _description);
        }
    }
}
