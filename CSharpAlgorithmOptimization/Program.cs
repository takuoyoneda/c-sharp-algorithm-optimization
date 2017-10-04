using System;
using System.Collections.Generic;

namespace CSharpAlgorithmOptimization
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(IsValid(6));

			Console.ReadLine();
		}

		static List<int> Values;

		static bool IsValid(int count)
		{
			Values = new List<int>() {1,2,3,4,5};

			List<int> legend_hero_id_list = new List<int>();

			bool is_duplicated = false;

			foreach (var h in Values)
			{
				is_duplicated = false;
				foreach (var i in legend_hero_id_list)
				{
					if (h == i)
					{
						is_duplicated = true;
					}
				}
				if (is_duplicated == false)
				{
					legend_hero_id_list.Add(h);
				}
			}

			//if (legend_hero_id_list.Count >= count)
			//{
			//	return true;
			//}
			return false;
		}

	}
}
