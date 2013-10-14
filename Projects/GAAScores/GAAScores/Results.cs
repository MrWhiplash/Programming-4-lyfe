using System;

namespace GAAScores
{
	public class Results
	{
		private string teamName1 ;
		private string teamName2;

		public string TeamName1 {
			get {
				return teamName1;
			}
			set{ teamName1 = value;}
		}

		public string TeamName2 {
			get {
				return TeamName2;
			}
			set{ teamName2 = value;}
		}

		public override string ToString()
		{
			return "Team 1: " + teamName1 + "\t\t\tTeam 2 :" + teamName2;
		}

		public void Winner()
		{



		}


		public Results (string name1, string name2)
		{
			this.teamName1 = name1;
			this.teamName2 = name2;

		}
	}
}

