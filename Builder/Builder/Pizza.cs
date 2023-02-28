using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {

        Dough _dough;
        Topping _topping;
        Sauce _sauce;
        string _type;

        public Pizza(Dough dough, Topping topping, Sauce sauce, string type)
        {
            _dough = dough;
            _topping = topping;
            _sauce = sauce;
            _type = type;
        }

        public override string ToString()
        {
            return $"Type: {_type}. Dough: {_dough.Description}. Topping {_topping.Description}. Sauce: {_sauce.Description}.";
        }


    }
}
