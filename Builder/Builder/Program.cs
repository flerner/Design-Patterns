using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PizzaBuilder> pizzaBuilders = new List<PizzaBuilder>();
            pizzaBuilders.Add(new FlatbreadPizzaBuilder());
            pizzaBuilders.Add(new SicilianPizzaBuilder());
            pizzaBuilders.Add(new StuffedPizzaBuilder());


            Console.WriteLine("Select the type of pizza");
            Console.WriteLine("1. FlatBread Pizza");
            Console.WriteLine("2. Sicilian Pizza");
            Console.WriteLine("3. Stuffed Pizza");
            Console.WriteLine("0 for exit");

            string lane;
            int pizzaNumber = -1;
            
            do
            {
                lane = Console.ReadLine();
                try
                {
                    pizzaNumber = int.Parse(lane);
                    Pizza pizza = pizzaBuilders[pizzaNumber-1].BuildPizza();
                    Console.WriteLine(pizza.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number");
                }
            } while (pizzaNumber != 0);
        }
    }
}
