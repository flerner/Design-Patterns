using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Builder
{
    public abstract class Dough
    {
        public string Description { get; set; }
    }
    public class Flatbread : Dough
    {
        public Flatbread() 
        {
            Description = "Flatbread dough";
        }
    }

    public class Sicilian : Dough
    {
        public Sicilian()
        {
            Description = "Sicilian dough";
        }
    }
    public class Stuffed : Dough
    {
        public Stuffed()
        {
            Description = "Stuffed dough";
        }
    }
}
