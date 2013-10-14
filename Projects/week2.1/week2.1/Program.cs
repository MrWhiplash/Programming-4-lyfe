using System;

namespace week2.
{
	class MainClass
	{
		public static void Main(string[] args)
	{
		int i = 0;

		Random r = new Random ();

			for(int j; j<1000; j++)
			{
				i = ((r.Next () % 11) + 10);
				Console.WriteLine;
			}



	}
	}
}
