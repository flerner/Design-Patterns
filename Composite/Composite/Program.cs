using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component root = new Directory("root");

            Component file1 = new File(10, "file1.txt");
            Component file2 = new File(15, "file2.txt");
            Component file3 = new File(20, "file3.txt");
            Component file4 = new File(25, "file4.txt");
            Component file5 = new File(30, "file5.txt");
            Component file6 = new File(35, "file6.txt");

            Component dir1 = new Directory("dir1");
            Component dir2 = new Directory("dir2");

            dir1.AddChildren(file1);
            dir2.AddChildren(file2);
            dir1.AddChildren(file3);
            dir1.AddChildren(file4);
            dir2.AddChildren(file5);

            root.AddChildren(dir1);
            root.AddChildren(dir2);
            root.AddChildren(file6);

            Console.WriteLine("Root size: " + root.GetSize());
            Console.WriteLine("Dir1 size: " + dir1.GetSize());

            Console.ReadKey();
        }
    }
}
