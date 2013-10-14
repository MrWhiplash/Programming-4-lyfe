using System;

namespace fibonaci
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			//Loop Operators
	
			//fibonaci containers
			int temp = 0;
			int prev = 0;
			int curr = 1;

			//Operations
			while (curr <=200) {
				temp = curr;
				curr = curr + prev;
				prev = temp;
				if (curr <= 200) {

					Console.WriteLine (curr);
				}
			}


		}
	}
}
