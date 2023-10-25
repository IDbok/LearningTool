using Weapons;
using System;

namespace LearningTool
{
    internal class Player
    {
        private Weapon[] weaponSlots;
        public Player()
        {
            weaponSlots = new Weapon[]
            {
                new BigGun()
                 
            };
        }
        public int getShotsCount() => weaponSlots.Length;
        public void ShotWhithWeapon(int shot) 
        {

            if (shot < weaponSlots.Length)
            {
                Weapon weapon = weaponSlots[shot];
                weapon.Shot();
            }
            else { Console.WriteLine("This slot doesn't exist. Try another!"); }
        }
    }
}
