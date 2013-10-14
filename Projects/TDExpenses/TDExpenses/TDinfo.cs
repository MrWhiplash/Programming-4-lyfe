using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TDExpenses
{
	public class TDinfo
	{
		public string[] data;
		string filename = "expenses.txt";
		public string[] lines;
		public List<Expense> expenses;

		private void LoadExpenses(string filename)
		{
			int i = 0;
			int count = 0;

			lines = System.IO.File.ReadAllLines (filename);

			foreach(string line in lines)
			{
				count++;

			}
		
			for(i = 0; i < count ; i++)
			{

				data = lines[i].Split("\t".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

				Expense e = new Expense(data[0], data[1], data[2], data[3], data[4]);

				expenses.Add(e);
			}
		}
		public void PrintExpense(string party)
		{ 
			if (party.ToLower () == "lab"||party.ToLower () == "ind"||party.ToLower () == "ff"||party.ToLower () == "fg"||party.ToLower () == "sf"||party.ToLower () == "cc"||party.ToLower () == "wuag"||party.ToLower () == "pbp") {
			float MaxValue = 0;
			float MinValue = 1000000;
			string MinName = "";
			string MinValname = "";
			float partytotal = 0;
			float partytemp = 0;


			foreach (Expense e in expenses) {

				if (e.party.ToLower ().CompareTo (party.ToLower ()) == 0) {

					Console.WriteLine (e);
					if (e.AmountClaimed > MaxValue) {
						MaxValue = e.AmountClaimed;
						MinName = e.Name;
						partytemp = e.AmountClaimed;
						partytotal = partytemp + partytotal;
					}
					if (e.AmountClaimed < MinValue) {
						MinValue = e.AmountClaimed;
						MinValname = e.name;
					}
					
					}
 
			
		
				} 
				Console.WriteLine ("The Party claimed in total: " + partytotal);
				Console.WriteLine ("The Maximum Value Claimed is: " + MaxValue + " by " + MinName);
				Console.WriteLine ("The Minimum Value Claimed is: " + MinValue + " by " + MinValname);
		
			} else {

				Console.WriteLine ("Party Not Found");

			}
		}

		public TDinfo ()
		{
			expenses = new List<Expense> ();
			LoadExpenses(filename);
		}
	}
}

