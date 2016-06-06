using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerHeroesCalc
{
	public class Position
	{
		public List<Hero> Heroes;

		public Position(Position Pos)
		{
			Heroes = new List<Hero>(Pos.Heroes.Count());
			Pos.Heroes.ForEach((item)
				 =>
				 {
					 Heroes.Add((Hero)item.Clone());
				 });
		}

		public Position()
		{
			Heroes = new List<Hero>();
			Heroes.Add(new Hero(0, "Treebeast", 0, 0, 50, 5));
			Heroes[0].Skills.Add(new Skill(10, 500, 0, 100));
			Heroes[0].Skills.Add(new Skill(25, 1250, 0, 100));
			Heroes[0].Skills.Add(new Skill(50, 5000, 0, 100));
			Heroes[0].Skills.Add(new Skill(75, 40000, 0, 150));

			Heroes.Add(new Hero(1, "Ivan", 0, 0, 250, 22));
			Heroes[1].Skills.Add(new Skill(10, 2500, 0, 100));
			Heroes[1].Skills.Add(new Skill(25, 6250, 0, 100));
			Heroes[1].Skills.Add(new Skill(50, 25000, 0, 100));
			Heroes[1].Skills.Add(new Skill(125, 1e7, 0, 150));

			Heroes.Add(new Hero(2, "Brittany", 0, 0, 1000, 74));
			Heroes[2].Skills.Add(new Skill(10, 10000, 0, 100));
			Heroes[2].Skills.Add(new Skill(25, 25000, 0, 100));
			Heroes[2].Skills.Add(new Skill(50, 1e5, 0, 100));
			Heroes[2].Skills.Add(new Skill(75, 8e5, 0, 100));

			Heroes.Add(new Hero(3, "The Wandering Fisherman", 0, 0, 4000, 245));
			Heroes[3].Skills.Add(new Skill(10, 40000, 0, 100));
			Heroes[3].Skills.Add(new Skill(25, 1e5, 0, 100));
			Heroes[3].Skills.Add(new Skill(50, 4e5, 0, 100));
			Heroes[3].Skills.Add(new Skill(75, 3.2e6, 1, 25));

			Heroes.Add(new Hero(4, "Betty Clicker", 0, 0, 20000, 976));
			Heroes[4].Skills.Add(new Skill(10, 2e5, 1, 20));
			Heroes[4].Skills.Add(new Skill(25, 5e5, 1, 20));
			Heroes[4].Skills.Add(new Skill(50, 2e6, 1, 20));
			Heroes[4].Skills.Add(new Skill(75, 1.6e7, 1, 20));

			Heroes.Add(new Hero(5, "The Masked Samurai", 0, 0, 1e5, 3725));
			Heroes[5].Skills.Add(new Skill(10, 1e6, 0, 100));
			Heroes[5].Skills.Add(new Skill(25, 2.5e6, 0, 100));
			Heroes[5].Skills.Add(new Skill(50, 1e7, 0, 100));
			Heroes[5].Skills.Add(new Skill(75, 8e7, 0, 150));

			Heroes.Add(new Hero(6, "Leon", 0, 0, 4e5, 10859));
			Heroes[6].Skills.Add(new Skill(10, 4e6, 0, 100));
			Heroes[6].Skills.Add(new Skill(25, 1e7, 0, 100));
			Heroes[6].Skills.Add(new Skill(50, 4e7, 0, 100));
			Heroes[6].Skills.Add(new Skill(75, 3.2e8, 1, 25));

			Heroes.Add(new Hero(7, "The Great Forest Seer", 0, 0, 2.5e6, 47143));
			Heroes[7].Skills.Add(new Skill(10, 2.5e7, 0, 100));
			Heroes[7].Skills.Add(new Skill(25, 6.25e7, 0, 100));
			Heroes[7].Skills.Add(new Skill(50, 2.5e8, 0, 100));
			Heroes[7].Skills.Add(new Skill(75, 2e9, 0, 150));

			Heroes.Add(new Hero(8, "Alexa", 0, 0, 1.5e7, 1.86e5));
			Heroes[8].Skills.Add(new Skill(25, 3.75e8, 0, 125));
			Heroes[8].Skills.Add(new Skill(50, 1.5e9, 0, 125));

			Heroes.Add(new Hero(9, "Natalia", 0, 0, 1e8, 7.82e5));
			Heroes[9].Skills.Add(new Skill(10, 1e9, 0, 100));
			Heroes[9].Skills.Add(new Skill(25, 2.5e9, 0, 100));
			Heroes[9].Skills.Add(new Skill(50, 1e10, 0, 100));
			Heroes[9].Skills.Add(new Skill(75, 8e10, 0, 150));

			Heroes.Add(new Hero(10, "Mercedes", 0, 0, 8e8, 3.721e6));
			Heroes[10].Skills.Add(new Skill(10, 8e9, 0, 100));
			Heroes[10].Skills.Add(new Skill(25, 2e10, 0, 100));
			Heroes[10].Skills.Add(new Skill(50, 8e10, 0, 100));
			Heroes[10].Skills.Add(new Skill(75, 6.4e11, 0, 150));

			Heroes.Add(new Hero(11, "Bobby", 0, 0, 6.5e9, 1.701e7));
			Heroes[11].Skills.Add(new Skill(10, 6.5e10, 0, 100));
			Heroes[11].Skills.Add(new Skill(25, 1.62e11, 0, 100));
			Heroes[11].Skills.Add(new Skill(50, 6.5e11, 0, 100));
			Heroes[11].Skills.Add(new Skill(75, 5.2e12, 0, 150));

			Heroes.Add(new Hero(12, "Broyle Lindeoven", 0, 0, 5e10, 6.9064e7));
			Heroes[12].Skills.Add(new Skill(10, 5e11, 1, 25));
			Heroes[12].Skills.Add(new Skill(25, 1.25e12, 0, 100));
			Heroes[12].Skills.Add(new Skill(50, 5e12, 0, 100));
			Heroes[12].Skills.Add(new Skill(75, 4e13, 0, 150));

			Heroes.Add(new Hero(13, "Sir George II", 0, 0, 4.5e11, 4.6e8));
			Heroes[13].Skills.Add(new Skill(10, 4.5e12, 0, 100));
			Heroes[13].Skills.Add(new Skill(25, 1.125e13, 0, 100));
			Heroes[13].Skills.Add(new Skill(50, 4.5e13, 0, 100));
			Heroes[13].Skills.Add(new Skill(75, 3.6e14, 0, 150));

			Heroes.Add(new Hero(14, "King Midas", 0, 0, 4e12, 3.017e9));
			Heroes[14].Skills.Add(new Skill(10, 4e13, 1, 25));
			Heroes[14].Skills.Add(new Skill(25, 1e14, 1, 25));
			Heroes[14].Skills.Add(new Skill(50, 4e14, 1, 25));
			Heroes[14].Skills.Add(new Skill(75, 3.2e15, 1, 50));

			Heroes.Add(new Hero(15, "Referi Jerator", 0, 0, 3.6e13, 2.009e10));
			Heroes[15].Skills.Add(new Skill(10, 3.6e14, 0, 100));
			Heroes[15].Skills.Add(new Skill(25, 9e14, 0, 100));
			Heroes[15].Skills.Add(new Skill(50, 3.6e15, 0, 100));
			Heroes[15].Skills.Add(new Skill(75, 6.7e16, 0, 150));

			Heroes.Add(new Hero(16, "Abaddon", 0, 0, 3.2e14, 1.31e11));
			Heroes[16].Skills.Add(new Skill(10, 3.2e15, 0, 125));
			Heroes[16].Skills.Add(new Skill(25, 8e15, 0, 125));
			Heroes[16].Skills.Add(new Skill(50, 1.09e15, 0, 125));

			Heroes.Add(new Hero(17, "Ma Zhu", 0, 0, 2.7e15, 8.14e11));
			Heroes[17].Skills.Add(new Skill(10, 2.7e16, 0, 100));
			Heroes[17].Skills.Add(new Skill(25, 6.75e16, 0, 100));
			Heroes[17].Skills.Add(new Skill(50, 2.7e17, 0, 100));
			Heroes[17].Skills.Add(new Skill(75, 2.16e18, 0, 150));

			Heroes.Add(new Hero(18, "Amenhotep", 0, 0, 2.4e16, 5.335e12));
			Heroes[18].Skills.Add(new Skill(10, 2.4e17, 0, 100));
			Heroes[18].Skills.Add(new Skill(25, 6e17, 1, 20));
			Heroes[18].Skills.Add(new Skill(50, 2.4e18, 1, 20));

			Heroes.Add(new Hero(19, "Beastlord", 0, 0, 3e17, 4.9143e13));
			Heroes[19].Skills.Add(new Skill(10, 3e18, 0, 100));
			Heroes[19].Skills.Add(new Skill(25, 7.5e18, 0, 100));
			Heroes[19].Skills.Add(new Skill(50, 3e19, 0, 100));
			Heroes[19].Skills.Add(new Skill(75, 2.4e20, 1, 10));

			Heroes.Add(new Hero(20, "Athena", 0, 0, 9e18, 1.086e15));
			Heroes[20].Skills.Add(new Skill(10, 9e18, 0, 100));
			Heroes[20].Skills.Add(new Skill(25, 2.25e20, 0, 100));
			Heroes[20].Skills.Add(new Skill(50, 9e20, 0, 100));
			Heroes[20].Skills.Add(new Skill(100, 7.2e21, 0, 100));

			Heroes.Add(new Hero(21, "Aphrodite", 0, 0, 3.5e20, 3.1124e16));
			Heroes[21].Skills.Add(new Skill(10, 3.5e21, 0, 100));
			Heroes[21].Skills.Add(new Skill(25, 8.75e21, 0, 100));
			Heroes[21].Skills.Add(new Skill(50, 3.5e22, 0, 100));
			Heroes[21].Skills.Add(new Skill(125, 2.8e24, 0, 100));

			Heroes.Add(new Hero(22, "Shinatobe", 0, 0, 1.4e22, 9.17e17));
			Heroes[22].Skills.Add(new Skill(10, 1.4e23, 0, 100));
			Heroes[22].Skills.Add(new Skill(25, 3.5e23, 1, 10));
			Heroes[22].Skills.Add(new Skill(50, 1.4e24, 0, 100));
			Heroes[22].Skills.Add(new Skill(75, 1.12e25, 0, 100));

			Heroes.Add(new Hero(23, "Grant", 0, 0, 4.2e24, 2.02e20));
			Heroes[23].Skills.Add(new Skill(10, 4.2e25, 1, 25));
			Heroes[23].Skills.Add(new Skill(25, 1.04e26, 0, 100));
			Heroes[23].Skills.Add(new Skill(50, 4.19e26, 1, 25));
			Heroes[23].Skills.Add(new Skill(75, 3.359e27, 0, 100));

			Heroes.Add(new Hero(24, "Frostleaf", 0, 0, 2.1e27, 7.4698e22));
			Heroes[24].Skills.Add(new Skill(10, 2.1e28, 0, 100));
			Heroes[24].Skills.Add(new Skill(25, 5.25e28, 0, 100));
			Heroes[24].Skills.Add(new Skill(50, 2.1e29, 1, 25));

			Heroes.Add(new Hero(25, "Dread Knight", 0, 0, 1e40, 1.31e32));
			Heroes[25].Skills.Add(new Skill(10, 1e41, 0, 100));
			Heroes[25].Skills.Add(new Skill(25, 2.5e41, 0, 100));
			Heroes[25].Skills.Add(new Skill(50, 1e42, 0, 100));
			Heroes[25].Skills.Add(new Skill(100, 8e42, 0, 150));

			Heroes.Add(new Hero(26, "Atlas", 0, 0, 1e55, 9.66e44));
			Heroes[26].Skills.Add(new Skill(10, 1e56, 0, 100));
			Heroes[26].Skills.Add(new Skill(25, 2.5e56, 0, 100));
			Heroes[26].Skills.Add(new Skill(50, 1e57, 0, 100));
			Heroes[26].Skills.Add(new Skill(100, 8e57, 0, 150));

			Heroes.Add(new Hero(27, "Terra", 0, 0, 1e70, 7.113e57));
			Heroes[27].Skills.Add(new Skill(10, 1e71, 0, 100));
			Heroes[27].Skills.Add(new Skill(25, 2.5e71, 0, 100));
			Heroes[27].Skills.Add(new Skill(50, 1e72, 0, 100));
			Heroes[27].Skills.Add(new Skill(100, 8e72, 0, 150));

			Heroes.Add(new Hero(28, "Phthalo", 0, 0, 1e85, 5.24e70));
			Heroes[28].Skills.Add(new Skill(10, 1e86, 0, 100));
			Heroes[28].Skills.Add(new Skill(25, 2.5e86, 0, 100));
			Heroes[28].Skills.Add(new Skill(50, 1e87, 0, 100));
			Heroes[28].Skills.Add(new Skill(100, 8e87, 0, 150));

			Heroes.Add(new Hero(29, "Orntchya Gladeye", 0, 0, 1e100, 3.861e83));
			Heroes[29].Skills.Add(new Skill(10, 1e101, 0, 100));
			Heroes[29].Skills.Add(new Skill(25, 2.5e101, 0, 100));
			Heroes[29].Skills.Add(new Skill(50, 1e102, 0, 100));
			Heroes[29].Skills.Add(new Skill(100, 8e102, 0, 150));

			Heroes.Add(new Hero(30, "Lillin", 0, 0, 1e115, 2.845e96));
			Heroes[30].Skills.Add(new Skill(10, 1e116, 0, 100));
			Heroes[30].Skills.Add(new Skill(25, 2.5e116, 0, 100));
			Heroes[30].Skills.Add(new Skill(50, 1e117, 0, 100));
			Heroes[30].Skills.Add(new Skill(100, 8e117, 0, 150));

			Heroes.Add(new Hero(31, "Cadmia", 0, 0, 1e130, 2.096e109));
			Heroes[31].Skills.Add(new Skill(10, 1e131, 0, 100));
			Heroes[31].Skills.Add(new Skill(25, 2.5e131, 0, 100));
			Heroes[31].Skills.Add(new Skill(50, 1e132, 0, 100));
			Heroes[31].Skills.Add(new Skill(100, 8e132, 0, 150));

			Heroes.Add(new Hero(32, "Alabaster", 0, 0, 1e145, 1.544e122));
			Heroes[32].Skills.Add(new Skill(10, 1e146, 0, 100));
			Heroes[32].Skills.Add(new Skill(25, 2.5e146, 0, 100));
			Heroes[32].Skills.Add(new Skill(50, 1e147, 0, 100));
			Heroes[32].Skills.Add(new Skill(100, 8e147, 0, 150));

			Heroes.Add(new Hero(33, "Astraea", 0, 0, 1e160, 1.137e135));
			Heroes[33].Skills.Add(new Skill(10, 1e161, 0, 100));
			Heroes[33].Skills.Add(new Skill(25, 2.5e161, 0, 100));
			Heroes[33].Skills.Add(new Skill(50, 1e162, 0, 100));
			Heroes[33].Skills.Add(new Skill(100, 8e162, 0, 150));

			Heroes.Add(new Hero(34, "Chiron", 0, 0, 1e175, 1.137e148));
			Heroes[34].Skills.Add(new Skill(10, 1e176, 0, 100));
			Heroes[34].Skills.Add(new Skill(25, 2.5e176, 0, 100));
			Heroes[34].Skills.Add(new Skill(50, 1e177, 0, 100));
			Heroes[34].Skills.Add(new Skill(100, 8e177, 0, 150));

			Heroes.Add(new Hero(35, "Moloch", 0, 0, 1e190, 1.137e161));
			Heroes[35].Skills.Add(new Skill(10, 1e191, 0, 100));
			Heroes[35].Skills.Add(new Skill(25, 2.5e191, 0, 100));
			Heroes[35].Skills.Add(new Skill(50, 1e192, 0, 100));
			Heroes[35].Skills.Add(new Skill(100, 8e192, 0, 150));

			Heroes.Add(new Hero(36, "Chiron", 0, 0, 1e205, 1.137e174));
			Heroes[36].Skills.Add(new Skill(10, 1e206, 0, 100));
			Heroes[36].Skills.Add(new Skill(25, 2.5e206, 0, 100));
			Heroes[36].Skills.Add(new Skill(50, 1e207, 0, 250));
			Heroes[36].Skills.Add(new Skill(100, 8e207, 1, 50));

			Heroes.Add(new Hero(37, "Gog", 0, 0, 1e220, 1.137e161));
			Heroes[37].Skills.Add(new Skill(10, 1e221, 0, 100));
			Heroes[37].Skills.Add(new Skill(25, 2.5e221, 0, 100));
			Heroes[37].Skills.Add(new Skill(50, 1e222, 0, 250));
			Heroes[37].Skills.Add(new Skill(100, 8e222, 1, 50));

			Heroes.Add(new Hero(38, "Wepwawet", 0, 0, 1e235, 1.137e200));
			Heroes[38].Skills.Add(new Skill(25, 1e236, 0, 200));
			Heroes[38].Skills.Add(new Skill(100, 2.5e236, 0, 250));
		}

		public double GlobalDPS
		{
			get
			{
				double Result = 0;
				foreach (Hero h in Heroes)
				{
					Result += h.CurrentDPS;
				}
				return Result;
			}
		}

		public void NextStep(out int ID, out int Type, out double DpsIncrease, out double Cost)
		{
			double BestRatio = 0;
			int BestID = 0;
			int BestType = 0;
			double BestDPS = 0;
			double BestCost = 0;
			foreach(Hero h in Heroes)
			{
				double O1 = h.DpsIncreaseOn1Level(GlobalDPS)/h.NextLevelCost();
				double O2 = h.DpsIncreaseOnCheckpoint25(GlobalDPS)/h.LevelsToCheckpoint25Cost();
				double O3 = h.DpsIncreaseOnCheckpoint1000()/h.LevelsToCheckpoint1000Cost();

				if (O1 > BestRatio)
				{
					BestRatio = O1;
					BestType = 1;
					BestID = h.ID;
					BestDPS = h.DpsIncreaseOn1Level(GlobalDPS);
					BestCost = h.NextLevelCost();
				}
				if (O2 > BestRatio)
				{
					BestRatio = O2;
					BestType = 2;
					BestID = h.ID;
					BestDPS = h.DpsIncreaseOnCheckpoint25(GlobalDPS);
					BestCost = h.LevelsToCheckpoint25Cost();
				}
				if (O3 > BestRatio)
				{
					BestRatio = O3;
					BestType = 3;
					BestID = h.ID;
					BestDPS = h.DpsIncreaseOnCheckpoint1000();
					BestCost = h.LevelsToCheckpoint1000Cost();
				}
			}
			ID = BestID;
			Type = BestType;
			DpsIncrease = BestDPS;
			Cost = BestCost;
		}
	}
}
