using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerHeroesCalc
{
	public class Skill
	{
		public int Level;
		public double Cost;
		public int Type; // 0 - Local; 1 - Global; 2+ - reserved for cross-skills
		public double Mult; // Gold multiplier have same effect as damage multiplier, so i do not make it separate

		public Skill(int _Level, double _Cost, int _Type, double _Mult)
		{
			Level = _Level;
			Cost = _Cost;
			Type = _Type;
			Mult = _Mult;
		}
	}
}
