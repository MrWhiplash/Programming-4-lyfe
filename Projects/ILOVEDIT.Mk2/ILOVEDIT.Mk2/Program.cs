using System;

namespace ILOVEDIT.Mk2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 0; i <21; i++) {


				for (int j = 0; i > j; j++) {

					if (i < j) {
						j = j - i;
						Console.Write (" ");
					} else {

						Console.Write (" ");
					}
				}


				Console.WriteLine ("I Love D.I.T.");
			}
		}
	}
}
