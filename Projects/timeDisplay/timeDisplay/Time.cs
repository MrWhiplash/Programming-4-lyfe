using System;

namespace timeDisplay
{
	public class timer
	{



	}
	
	public struct Time
	{
		private int hour;
		private int second;
		private int minute;

		public int Minute {
			get {
				return minute;
			}
			set{second = value;}

		}

		public int Second {
			get {
				return second;
			}
			set {second = value;}
		}

		public int Hour {
			get {
				return hour;
			}
			set{hour = value;}
		}

	}
}

