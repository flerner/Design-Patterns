using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Sauce
    {
        public string Description { get; set; }
    }
    public class Tomatoes : Sauce
    {
        public Tomatoes() { Description = "Tomatoes sauce"; }
    }
    public class FourCheese : Sauce
    {
        public FourCheese() { Description = "Four cheese sauce"; }
    }
    public class Pesto : Sauce
    {
        public Pesto() { Description = "Pesto sauce"; }
    }
}
