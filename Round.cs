using System;

namespace ArenaFighter
{
	public class Round
	{
		private Random rand = new Random();
		private int opHP, chHP, opS, chS, diceRoll;
		
		public Round(int chS,int chHP,int opS,int opHP)
		{
			this.chS = chS;
			this.chHP = chHP;
			this.opS = opS;
			this.opHP = opHP;
		}
		private int RollDice()
        {
			diceRoll = rand.Next(1, 6);
			Console.WriteLine($"Dice is: {diceRoll}!");
			return diceRoll;
        }

		public bool Match()
		{
			while (chHP > 0 || opHP > 0)
			{
			
					RollResult();
					
					if(chHP < opS)
                    {
						return false; 
                    }else
                    {
						chHP -= opS;
						opHP -= chS;
                        if (chHP < opS)
                        {
							Console.WriteLine($"\nYour HP is already too low to win. {chHP} HP < {opS} Strength.");
							return false;
                        }else
                            if (chS > opHP)
                        {
							Console.WriteLine($"\nOpponent's HP is already too low to win. {opHP} HP < {chS} Strength.");
							return true;
                        }
					}
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("\n" + "Next roll!");
					Console.ResetColor();
				
			}
            if (chHP > opHP)
            {
				return true;
            }
            else if(chHP == opHP)
            {
				if (chS > opS)
                {
					Console.WriteLine("\nYour strength was greater than your opponent's!");
					return true;
                }
                else
                {
					Console.WriteLine("\nYour opponent's strength was greater than yours!");
					return false;
				}
			}
					
			Console.WriteLine("Invalid match.");
			return false;
        }


		public void RollResult()
        {
			chS += RollDice();
			Console.WriteLine($"Hero Strength is now: {chS}");
			opS += RollDice();
			Console.WriteLine($"Opponent Strength is now: {opS}");
		}


		
	}
}

