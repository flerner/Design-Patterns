using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Forest
    {
        private List<Tree> trees;
        
        public Forest()
        {
            trees = new List<Tree>();
            
        }
        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType type = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new Tree(x, y, type);
            trees.Add(tree);
        }
        public void Draw()
        {
            foreach(Tree t in trees)
            {
                t.Draw();
            }
        }
        
    }
}
