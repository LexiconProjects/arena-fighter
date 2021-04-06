using System;

namespace ArenaFighter
{
	public class Battle
	{
		private Character hero = new Character("");
		private string heroName="";
		
		private string log;
		
		private int battleNumber = 1, victoriesNumber = 0;
		private string choice;
		private bool wonRound;
		private int score = 0;
		private const int RETIRE_SCORE = 150;
		private const int DEFEAT_SCORE = 50;
		private const int VICTORY_SCORE = 200;
		


		public Battle()
		{
			CreateHero();
			StartBattle();
		}

		private void StartBattle()
		{
			Console.WriteLine("-------------------------------------------------------------------------");
			Console.WriteLine($"{hero.getName()} has {hero.getHealth()} HP and deals {hero.getStrength()} damage.");
			Character opponent = new Character("");
			Console.WriteLine($"Your opponent has {opponent.getHealth()} HP and deals {opponent.getStrength()} damage.");
			Console.WriteLine("You roll first, let's go!\n");

			Round round = new Round(hero.getStrength(), hero.getHealth(), opponent.getStrength(), opponent.getHealth());
			wonRound = round.Match();

			if (wonRound)
			{
				victoriesNumber++;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\nYOU WON!");
				Console.ResetColor();
				Console.WriteLine("\nChoose to gain more prestige by fighting again or retire in glory!");

				do
				{
					Console.WriteLine("Retire - r // Play again - p");
					choice = Console.ReadLine();
				} while (!(choice.Equals("r")|| choice.Equals("p")));
				
		
				switch (choice)
				{
					case "r":
						log = $"\nHere are {heroName}'s stats: \n" +
							  $"NUMBER OF BATTLES: {battleNumber} \n" +
							  $"NUMBER OF VICTORIES: {victoriesNumber} \t (+{VICTORY_SCORE * victoriesNumber} points) \n" +
							  $"ACHIEVEMENT: Retired in Glory \t (+{RETIRE_SCORE} points) ";
						score = VICTORY_SCORE * victoriesNumber +RETIRE_SCORE;
						wonRound = false;
						break;

					case "p":
						battleNumber++;
						Console.WriteLine();
						StartBattle();
						break;


				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"YOU LOST!");
				Console.ResetColor();

				log = $"\nHere are {heroName}'s stats: \n" +
					  $"NUMBER OF BATTLES: {battleNumber}  \n" +
					  $"NUMBER OF VICTORIES: {victoriesNumber} \t (+{VICTORY_SCORE * victoriesNumber} points) \n" +
					  $"ACHIEVEMENT: Died in Battle \t (+{DEFEAT_SCORE} points) ";
				score = VICTORY_SCORE * victoriesNumber + DEFEAT_SCORE;
				wonRound = false;

			}

		}

		private void CreateHero()
        {
			Console.WriteLine("To begin, enter your hero's name: ");
			heroName = Console.ReadLine();
			hero = new Character(heroName);
		}


		public string getBattleLog()
        {
			return log;
        }

		public int getScore()
        {
			return score;
        }
	}
		

}

