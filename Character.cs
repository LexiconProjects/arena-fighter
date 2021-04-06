using System;

namespace ArenaFighter
{
	public class Character
	{
		private string name;
		private int strength, health;
		const int INITIAL_HEALTH = 100;
		private Random random = new Random();

		public Character(string name)
		{
			this.name = name;
			this.strength = random.Next(1, 50);
			health = INITIAL_HEALTH;
		}

		public string getName()
        {
			return name;
        }

		public int getStrength()
        {
			return strength;
        }

		public int getHealth()
        {
			return health;
        }

		 
	}



}

