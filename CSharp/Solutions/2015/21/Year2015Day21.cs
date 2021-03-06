using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Common;

namespace AdventOfCode.Solutions._2015._21
{
	// ReSharper disable once UnusedMember.Global
	public class Year2015Day21 : ISolution
	{
		public string Part1(IEnumerable<string> input)
		{
			var enemy = GetEnemy(input);
			var winners = Game.ExecuteUntilWin(enemy);
			return winners.Min(r => r.EqipmentCost).ToString();
		}

		public string Part2(IEnumerable<string> input)
		{
			var enemy = GetEnemy(input);
			var losers = Game.ExecuteUntilLose(enemy);
			return losers.Max(r => r.EqipmentCost).ToString();
		}
		
		private static Character GetEnemy(IEnumerable<string> input)
		{
			var enumerable = input as string[] ?? input.ToArray();
			var hp = int.Parse(enumerable[0].Split(":")[1].Trim());
			var damage = int.Parse(enumerable[1].Split(":")[1].Trim());
			var defense = int.Parse(enumerable[2].Split(":")[1].Trim());
			return new Character
			{
				HP = hp,
				Armor = new Armor { Defense = defense },
				Weapon = new Weapon { Damage = damage }
			};
		}
	}
}