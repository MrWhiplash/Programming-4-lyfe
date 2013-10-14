using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TDExpenses
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			string userq = "run";

			TDinfo NewLib = new TDinfo();
			while(userq.ToLower() != "quit"){
				Console.WriteLine ("Please Enter a Party to search for, Remember to use names provided! Or type 'quit' to quit!");
				userq = Console.ReadLine ();
				if (userq == "clear") {
					Console.Clear ();
					userq = "run";
				}
				NewLib.PrintExpense(userq);


			}




			

		}
	}
}
