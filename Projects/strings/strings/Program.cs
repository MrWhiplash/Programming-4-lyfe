using System;

namespace strings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string n;
			n = "i love";
			n = n + " cupcakes";
			Console.WriteLine (n);

			string s = n.Substring (7);
			Console.WriteLine (s);
			s = n.Substring (7, 3);
			Console.WriteLine (s);

			Console.WriteLine ("" + n[7] + n[8] + n[9]);

			for (int i = s.Length - 1; i >= 0 ;i-- ){
				Console.Write (s[i]);
			}

			int index = n.IndexOf ("Cupcakes");
			if (index == -1) {
				Console.WriteLine ("Not Found");
			} else {
				n = n.Substring (0, index);
				Console.WriteLine (n);
			}

			if (n.StartsWith ("I l")) {
				Console.WriteLine ("It starts with I l");
			}

			n = "I love cupcakes and more cupcakes";

			index = n.IndexOf ("cupcakes");
			index = n.LastIndexOf ("cupcakes");

			n = n.Replace ("love", "hate");
			Console.WriteLine (n);

			//Comparing Strings
			n = "Hello";
			string nn = "World"; 

			if (n == nn) {
				Console.WriteLine ("Equals");
			} else {
				Console.WriteLine ("not equals");
			}


		}


	}
}
