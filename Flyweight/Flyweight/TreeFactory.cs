using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TreeFactory
    {
        public static List<TreeType> treeTypes = new List<TreeType>();

       
        public static TreeType GetTreeType(string name, string color, string texture)
        {
            int i = 0;
            while (i < treeTypes.Count)
            {
                if (treeTypes[i].Name == name && treeTypes[i].Color == color && treeTypes[i].Texture == texture)
                {
                    return treeTypes[i];
                }
                i++;
                
            }
            TreeType type = new TreeType(name, color, texture);
            treeTypes.Add(type);
            return type;
        }
    }
}
