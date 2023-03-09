using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Gun : Weapon
    {
        public string Shoot()
        {
            return "Shooting a Gun";
        }
    }
}
