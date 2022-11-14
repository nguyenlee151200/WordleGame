using System.Linq;
using System.Runtime.CompilerServices;

namespace WordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string play = "";
            Game wordleGame = new Game();
            wordleGame.DisplayDetails();
            while (true)
            {
                Console.WriteLine("Would you like to play My Wordle [y|n] ?");//stage 3:
                play = Console.ReadLine();//stage 3:
                if (play == "y" || play == "Y")
                {
                    wordleGame.WordleGame();
                    //stage 11: loop checks for input characters
                    while (true)
                    {
                        Console.WriteLine("Would you like to play again [y|n] ?");
                        play = Console.ReadLine();
                        if (play == "y" || play == "Y")
                        {
                            wordleGame.WordleGame();
                        }
                        else if (play == "n" || play == "N")
                        {
                            Console.WriteLine("Thank you !!!");
                            return;
                        }
                    }
                }
                else if (play == "n" || play == "N")
                {
                    Console.WriteLine("Thank you !!!");
                    return;
                }
            }

        }
    }
    
}
