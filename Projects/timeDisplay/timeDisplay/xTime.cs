using System;
using System.Diagnostics;

namespace timeDisplay
{
	public class xTime
	{
			private int hour = 12;
			private int second = 0;
			private int minute = 0;

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

		public xTime ()
		{
			Stopwatch stopwatch = new Stopwatch ();
			stopwatch.Start ();
			minute = Minute;
			seconds = stopwatch.Elapsed;
			hour = Hour;



			int i = 0;
			while(i < 0)
			{
				for(second = 0;second <= 60;second++)
				{
					if(second == 60){
						minute++;
						if(minute == 60){
							hour++;
							if(hour < 23){
								hour = 0;
							}
						}
					}
				}
				Console.WriteLine(hour + " " + minute + " " + second);
				Console.Clear();

			}

		}
	}
}

