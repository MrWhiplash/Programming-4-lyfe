using System;

namespace TUT.WEEK3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 0;
			while (true) {
				Console.WriteLine (i);
				i++;
				if (i > 3) {
					break;
				}
			}
		}
	}
}
