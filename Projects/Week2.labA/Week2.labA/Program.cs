using System;

namespace Week2.labA
{
	class MainClass
	{
		//lolCount Method
		static int lolCount(string s){


			int numLols = 0;
			int i = 0;
			int index = 0; 

			for (i = 0 ; i < 10 ;  i = i + 3) {
				i = i + index; 
				if (index == s.IndexOf ("lol", i)) {
					numLols = numLols++;
				}

			}
			return numLols;
		}

		//Main Method
		public static void Main (string[] args)
		{

			//strings
			string s1 = "Wow that was a funny lol.";
			string s2 = "lol!! I laughed so rhard! lol";
			string s3 = "U r lame. lol lol lol";
			string s4 = "lollollollollollollollol!!!!!";


			Console.WriteLine ("The lol count of" + s1 + "is " + lolCount(s1));
			Console.WriteLine ("The lol count of" + s2 + "is " + lolCount(s2));
			Console.WriteLine ("The lol count of" + s3 + "is " + lolCount(s3));
			Console.WriteLine ("The lol count of" + s4 + "is " + lolCount(s4));


		}
	}
}
