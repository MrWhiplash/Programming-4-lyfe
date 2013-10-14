using System;

namespace quadraticOP
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Declarations
			//string a, b, c;
			double q, w, e;

			double x, y = 0;

			//Reading in Values
			Console.WriteLine ("Please Enter A");
			double.TryParse (Console.ReadLine (), out q);//converting from ascii to double(numeral)
			  Console.Clear();

			Console.WriteLine ("Please Enter B");
			double.TryParse (Console.ReadLine (), out w);//converting from ascii to double(numeral)
			  Console.Clear();
				
			Console.WriteLine ("Please Enter C");
			double.TryParse (Console.ReadLine (), out e);//converting from ascii to double(numeral)
			  Console.Clear();
					
			//Operations


			x = -w + (Math.Sqrt ((w * w) - (4 * q * e)));
			x = x / (2 * q);
			y = -w - (Math.Sqrt ((w * w) - (4 * q * e)));
			y = y / (2 * q);
			
				

		
			Console.WriteLine (x);
			Console.WriteLine (y);

		}
	}
}
