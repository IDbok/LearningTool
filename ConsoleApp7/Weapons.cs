using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Weapon
    {
        public void Shot()
        {
            Console.WriteLine("Shot");
        }
    }

    class BigGun:Weapon 
    {
        private int shotAmount;

        public void Shot() 
        {
            if (shotAmount == 0) { Console.WriteLine("You need to load the weapon!"); }
            else
            {
                base.Shot();
                this.shotAmount--;
            }
        }
    }
}
