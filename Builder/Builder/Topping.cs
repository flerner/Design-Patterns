using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Topping
    {
        public string Description { get; set; }
    }
    public class Anchovies : Topping
    {
        public Anchovies() { Description = "Anchovies topping"; }
    }
    public class Onion : Topping
    {
        public Onion() { Description = "Onion Topping"; }
    }
    public class OliveTomatoes : Topping
    {
        public OliveTomatoes() { Description = "Olive Tomatoes topping"; }
    }
}
