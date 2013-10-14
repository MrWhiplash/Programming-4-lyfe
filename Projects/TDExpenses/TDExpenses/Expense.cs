using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TDExpenses
{
	public class Expense
	{
		public string name;
		public string party;
		public string constituency;

		private float amountReturned;
		private float amountClaimed;
		public float totalSpent;

		public string Name {
			get {
				return name;
			}
		}

		public string Party {
			get {
				return party;
			}
		}

		public string Constituency {
			get {
				return constituency;
			}
		}

		public float AmountReturned {
			get {
				return amountReturned;
			}
			set{amountReturned = value;}
		}

		public float AmountClaimed {
			get {
				return amountClaimed;
			}
			set{ amountClaimed = value;}
		}

		public override string ToString()
		{
			return "Name: " + name + " Party`: " + party + " Constituency: " + constituency + " Amount Claimed: " + amountClaimed + " Amount Returned: " + amountReturned + " Total Spent: " + totalSpent;
		}

		public void totalcalculate()
		{
			totalSpent = amountClaimed - amountReturned;
		}

	
		public Expense (string name, string party, string constit, string amountret, string amountclaim)
		{
			this.name = Convert.ToString(name);
			this.party = Convert.ToString(party);
			this.constituency = Convert.ToString(constit);
			this.amountClaimed = float.Parse(amountclaim);
			this.amountReturned = float.Parse(amountret);
			this.totalSpent = amountClaimed - amountReturned;
		}
	}
}

