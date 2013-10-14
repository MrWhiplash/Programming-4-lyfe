using System;

namespace tutorialWeek3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 2;
			int j = 3;

			int k = (j++) - (--i);
			j *= k;

			Console.WriteLine (j);
		}
	}
}
