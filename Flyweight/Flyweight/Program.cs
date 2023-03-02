using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Forest forest = new Forest();
            forest.PlantTree(2, 3, "Pine", "Red", "Rough");

            //for this tree the tree factory will use the existing intrinsic object of type TreeType in the List<TreeType>
            forest.PlantTree(5, 6, "Pine", "Red", "Rough");
            forest.PlantTree(5, 8, "Bamboo", "Green", "Smooth");
            forest.Draw();

            Console.ReadKey();
        }
    }
}
