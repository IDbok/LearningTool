namespace Weapons
{
    internal abstract class Weapon
    {
        public virtual void Shot()
        {
            Console.WriteLine("Shot");
        }
    }

    class BigGun:Weapon 
    {
        private int shotAmount = 1;

        public override void Shot() 
        {
            if (shotAmount == 0) { Console.WriteLine("You are out of ammo! Load the weapon!\n"); }
            else
            {
                Console.Write("Big gun is ready!     ");
                Console.WriteLine("BIGBADABUM");
                this.shotAmount--;
            }
        }
    }
    class Pistiol : Weapon
    {
        private int shotAmount = 3;

        public override void Shot()
        {
            if (shotAmount == 0) { Console.WriteLine("You are out of ammo! Load the weapon!\n"); }
            else
            {
                Console.Write("Pistol is ready!     ");
                base.Shot();
                this.shotAmount--;
            }
        }
    }

    class Rifle : Weapon
    {
        private int shotAmount = 5;

        public override void Shot()
        {
            if (shotAmount == 0) { Console.WriteLine("You are out of ammo! Load the weapon!\n"); }
            else
            {
                Console.Write("Rifle is ready!     ");
                Console.WriteLine("Tratatatata");
                this.shotAmount--;
            }
        }

    }
    class WaterGun : Weapon
    {
        private int shotAmount = 1;

        public override void Shot()
        {
            if (shotAmount == 0) { Console.WriteLine("You are out of ammo! Load the weapon!\n"); }
            else
            {
                Console.Write("Water gun is ready!     ");
                Console.WriteLine("Psssssssss - pssssssss");
                //this.shotAmount--;
            }
        }

    }

}
