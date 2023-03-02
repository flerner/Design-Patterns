using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TreeType
    {
        private string _name;
        private string _color;
        private string _texture;

        public string Name { get { return _name; } }
        public string Color { get { return _color; } }
        public string Texture { get { return _texture; } }

        public TreeType(string name, string color, string texture)
        {
            _name = name;
            _color = color;
            _texture = texture;
        }
        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing {_name} of color {_color} and a texture {_texture} in {x}, {y}");
        }
    }
}
