﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerHeroesCalc
{
	public class Hero : ICloneable
	{
		public int ID {get; set;} // hero number
		public string Name {get; set;}
		public int CurrentLevel {get; set;}
		public int GlideLevel { get; set; }
		public double BaseCost;
		public double BaseDPS;
		public List<Skill> Skills;

		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public Hero(int _ID, string _Name, int _CurrentLevel, int _GlideLevel, double _BaseCost, double _BaseDPS)
		{
			ID = _ID;
			Name = _Name;
			CurrentLevel = _CurrentLevel;
			BaseCost = _BaseCost;
			BaseDPS = _BaseDPS;
			Skills = new List<Skill>();
		}

		public double DPS(int Level)
		{
			double TotalMult = 1;

			foreach (Skill s in Skills)
			{
				if ((s.Level <= Level) && (s.Type == 0))  // We do not calculate global multipliers here
					TotalMult = TotalMult * (1 + (s.Mult / 100));
			}
			double tmpDPS = BaseDPS * Level * (1 + GlideLevel / 2.0) * TotalMult;

			if (Level >= 200)
			{
				int Powerups25 = (Level / 25) - 7;
				int Powerups1000 = Level / 1000;

				tmpDPS = tmpDPS * Math.Pow(4, Powerups25);
				tmpDPS = tmpDPS * Math.Pow(2.5, Powerups1000);
			}

			return tmpDPS;
		}

		public double CurrentDPS
		{
			get
			{
				return DPS(CurrentLevel);
			}
		}

		public int NextCheckpoint()
		{
			return NextCheckpoint(CurrentLevel);
		}

		public int NextCheckpoint1K()
		{
			return (CurrentLevel / 1000 + 1) * 1000;
		}

		public int NextCheckpoint(int Level)
		{
			if (Level >= 200)
			{
				return (Level / 25 + 1) * 25;
			}
			else
			{
				int NextSkillCheckpoint = 0;
				foreach (Skill s in Skills)
				{
					if (s.Level > Level)
					{
						if ((NextSkillCheckpoint == 0) || (NextSkillCheckpoint > s.Level))
							NextSkillCheckpoint = s.Level;
					}
				}
				if (NextSkillCheckpoint == 0)
					return 200;
				else
					return NextSkillCheckpoint;
			}
		}

		public double LevelCost(int Level)
		{
			if (Level + 1 == NextCheckpoint(Level))
			{
				if (NextCheckpoint(Level) < 200)
				{
					double NextSkillCost = 0;
					foreach (Skill s in Skills)
					{
						if (s.Level == Level + 1)
						{
							NextSkillCost = s.Cost;
						}
					}
					return Math.Floor(BaseCost * Math.Pow(1.07, Level)) + NextSkillCost;
				}
			}
			return Math.Floor(BaseCost * Math.Pow(1.07, Level));
		}

		public double NextLevelCost()
		{
			return LevelCost(CurrentLevel);
		}

		public double LevelsToCheckpoint25Cost()
		{
			int i = CurrentLevel;
			int Checkpoint = NextCheckpoint(CurrentLevel);
			double TotalCost = 0;
			while (i+1 < Checkpoint)
			{
				TotalCost += BaseCost * Math.Pow(1.07, i);
				i++;
			}
			TotalCost += LevelCost(i);
			return TotalCost;
		}

		public double LevelsToCheckpoint1000Cost()
		{
			if (CurrentLevel < 200)
				return 1;
			int Next1K = (CurrentLevel / 1000 + 1) * 1000;
			double TotalCost = 0;
			int i = CurrentLevel;
			while (i < Next1K)
			{
				TotalCost += BaseCost * Math.Pow(1.07, i);
				i++;
			}
			return TotalCost;
		}

		public double DpsIncreaseOnCheckpoint25(double GlobalDPS)
		{
			int NextCP = NextCheckpoint(CurrentLevel);
			double LocalDpsIncrease = DPS(NextCP) - CurrentDPS;
			foreach (Skill s in Skills)
			{
				if (s.Level == NextCP)
				{
					if (s.Type == 1) // Global DPS Increase
					{
						return LocalDpsIncrease + ((GlobalDPS + LocalDpsIncrease) * s.Mult / 100);
					}
				}
			}
			return LocalDpsIncrease;
		}

		public double DpsIncreaseOn1Level(double GlobalDPS)
		{
			if (CurrentLevel + 1 == NextCheckpoint(CurrentLevel))
				return DpsIncreaseOnCheckpoint25(GlobalDPS);
			else
				return DPS(CurrentLevel + 1) - CurrentDPS;
		}

		public double DpsIncreaseOnCheckpoint1000()
		{
			// We are not going from level below 200 to 1000 in 1 step
			if (CurrentLevel < 200)
				return 0;
			else
			{
				int Next1K = (CurrentLevel / 1000 + 1) * 1000;
				return DPS(Next1K) - CurrentDPS;
			}
		}

	}
}
