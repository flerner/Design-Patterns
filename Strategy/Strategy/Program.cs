using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Felix";
            string line;
            int option = 5;
            List<Weapon> _strategies = new List<Weapon>();
            _strategies.Add(new Ak47());
            _strategies.Add(new Bazooka());
            _strategies.Add(new Gun());

            do
            {
                Console.WriteLine("Select your weapon");
                Console.WriteLine("1 for Ak47");
                Console.WriteLine("2 for bazooka");
                Console.WriteLine("3 for gun");
                Console.WriteLine("4 for shooting");
                Console.WriteLine("5 for exit");
                line = Console.ReadLine();

                //obviously this is a bad practice for a client input, is just for showing a simple example;
                //for a same action (shoot) we can have several strategies, and we can exchange them as the program is running
                try
                {
                    option = int.Parse(line);
                    if(option >0 && option <4) player1.ChangeStrategy(_strategies[option - 1]);
                    if(option == 4)
                    {
                        Console.WriteLine(player1.Shoot());
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            } while (option != 5);

            Console.ReadKey();
        }
    }
}
