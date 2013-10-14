using System;


namespace ILOVEDIT
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			for (int i = 0; i < 11; i++)
			{
				for (int j = 0; j < i; j++) {
					Console.Write (' ');
				}
				Console.WriteLine("I LOVE DIT!!");
			}


		}
		public static void NotMain (string[] args)
		{
			//Variable Declarations
			int i;
			int y = 0;
			int spaceIncrement = 0;
			string space= " ";

			//Incrementing for loop
			for (i = 0 ;i <= 10 ; i++)
			{
				Console.WriteLine ("I LOVE DIT!!!");

				if(i<=spaceIncrement)
				{
					spaceIncrement++;
					for (y=0; y<=spaceIncrement; y++) {
						Console.Write (space);
						Console.Write (space);
					}
				}

			}

			//Decrementing for loop
		
			for (i = 0 ;i <= 12 ; i++)
			{
				Console.WriteLine ("I LOVE DIT!!!");

				if(i-9 <=spaceIncrement)
				{
					spaceIncrement--;
					for (y=0 ; y<=spaceIncrement ;y++) {
						Console.Write (space);
						Console.Write (space);
					
					}
				}

			}

		}
	}
}
