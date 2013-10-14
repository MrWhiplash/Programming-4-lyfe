using System;

namespace stringdouble
{
	public class populate
	{

		//public string string1;
		//public string string2;
		public string uniqueCharacters;

//		public string String1 {
//			get {
//				return string1;
//			}
//			set{string1 = value;}
//		}
//
//		public string String2 {
//			get {
//				return string2;
//			}
//			set{string2 = value;}
//		}

		public populate (string string1)
		{
			int j = 0;
			char[] Unique = new char[string1.Length];

			for (int i=1; i < string1.Length; i++)
			{
				if (string1[i] == string1[i-1])
				{
					Unique[j++] = string1[i];
					Console.WriteLine ("Character Copied");
					Console.ReadKey ();
					Console.Clear ();
				}

				Console.WriteLine (Unique);
			}



		}
	}
}

