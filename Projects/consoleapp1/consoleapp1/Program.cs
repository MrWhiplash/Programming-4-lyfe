using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace consoleapp1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Declaring Variables

			int i;
			float f;
			bool b;

			// Assingnment Operations

			b = true;
			b = false;

			f = 6.0f;
			i = 10;

			i++;
			++i;
			i = i + 1;

			//Screen Operations

			Console.WriteLine ("What is your name?");
			string myName;
			myName = Console.ReadLine ();
			Console.WriteLine ("Hello " + myName);
			Console.WriteLine ("Hello {0} ", myName);
		}
	}
}
