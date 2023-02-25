using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        //Constructor private so no one can create multiple instances of this class
        private Singleton() { }

        public static Singleton GetInstance()
        {
            //first time this executes, the instance will be created, then if this method is called again, just return the previous instance, so always will be only one instance
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void Hi()
        {
            Console.WriteLine("Hello from Singleton");
        }
        public void Bye()
        {
            Console.WriteLine("Bye from Singleton");
        }
    }
}
