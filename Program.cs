using System;

namespace ArenaFighter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            Battle battle = new Battle();
            Console.WriteLine(battle.getBattleLog());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nFINAL SCORE IS { battle.getScore() } POINTS!");
            Console.ResetColor();
            Console.WriteLine("THANK YOU FOR PLAYING! BETTER LUCK NEXT TIME!");
            Console.WriteLine("-------------------------------------------------------------------------");
            

            Console.ReadLine();
           

        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Welcome to ARENA FIGHTER!");
            Console.WriteLine("Fight epic battles and gain prestige! \n");

            Console.WriteLine("Each battle you win will give you 200 points. \n" +
                "Win as many battles you can but be careful! If the enemy takes you down, you only get 50 points. \n" +
                "So retire in glory instead! That will award you 150 points");
            
            Console.WriteLine("GOOD LUCK! \n");


        }
    }
}
