using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace GAAScores
{
	public class ReadResults
	{
		string filename = "scores.txt";
		public string[] lines;
		public List<Results> results;

		private void LoadScores(string filename)
		{
		
			lines = System.IO.File.ReadAllLines (filename);
			int count = lines.Length;

			for (int i = 0; i < count; i++) {

								string[] data = lines [i].Split ("\t".ToCharArray (), StringSplitOptions.RemoveEmptyEntries);

				Results R = new Results (data[0], data[1]);

				results.Add (R);
			}
		}

		public void PrintResults(string teamName)
		{
			foreach(Results R in results)
			{
				Console.WriteLine (R);

			}

		}


		public ReadResults ()
		{
				results = new List<Results> ();
				LoadScores(filename);

		}
	}
}

