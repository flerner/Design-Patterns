using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Player
    {
        private Weapon _strategy;

        public Player()
        {

        }

        public void ChangeStrategy(Weapon strategy)
        {
            if(strategy == null)
            {
                throw new ArgumentNullException("Null strategy");
            }
            _strategy = strategy;
        }

        public string Name { get; set; }

        public string Shoot()
        {
            if(_strategy == null)
            {
                return "Weapon unavailable";
            }
            else
            {
                return _strategy.Shoot();
            }
        }
    }
}
