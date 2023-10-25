

using LearningTool;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello =)");
            
            Player player = new Player();
            while (true) 
            {
                Console.WriteLine("The Player has {0} weapon slots. Input a number to make a shot or -1 to end the Game.", player.getShotsCount());
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input == -1) { break; }
                    player.ShotWhithWeapon(input);
                    
                }
                else { Console.WriteLine("Uncorrect input value. Try again!");  }

            }

            Console.WriteLine("Game over;");
        }
        
    }

}