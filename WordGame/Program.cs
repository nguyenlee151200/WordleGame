using System.Linq;
using System.Runtime.CompilerServices;

namespace WordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string play = "";
            int totalPlay = 0;
            Game wordleGame = new Game();
            wordleGame.DisplayDetails();
            Guide();
            while (true)
            {
                Console.Write("Would you like to play My Wordle [y|n] ?");//stage 3:
                play = Console.ReadLine();//stage 3:
                if (play == "y" || play == "Y")
                {
                    wordleGame.WordleGame();
                    //stage 11: loop checks for input characters
                    totalPlay++;
                    while (true)
                    {
                        Console.Write("Would you like to play again [y|n] ?");
                        play = Console.ReadLine();
                        if (play == "y" || play == "Y")
                        {
                            wordleGame.WordleGame();
                            totalPlay++;
                        }
                        else if (play == "n" || play == "N")
                        {
                            Console.WriteLine("My Wordle Summary");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("You play {0} games:",totalPlay);
                            Console.WriteLine("\t|--> Number of wordles solved : {0}", wordleGame.Solved);
                            Console.WriteLine("\t|--> Number of wordles unsolved : {0}", wordleGame.Unsolved);
                            Console.WriteLine("Thank for playing !!!");
                            return;
                        }
                    }
                }
                else if (play == "n" || play == "N")
                {
                    Console.WriteLine("No worries... another time perhaps... :)");
                    return;
                }
            }

        }
        public static void Guide()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--          My Wordle!        --");
            Console.WriteLine("-- Gues the Wordle in 6 tries --");
            Console.WriteLine("--------------------------------");
        }
    }
   

}
