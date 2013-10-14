using System;

namespace week3.lab2
{
	struct Alcohol
	{
		private string _name;
		private int _units;

		public bool Safe()
		{
		if (_units <= 21)
			return true;
		else
			return false;
		}

		public Alcohol(string name, int units)
		{
			this._name = name;
			this._units = units;

		}
		public override string ToString ()
		{
			if (Safe ()) {
				return("Slow down there lad");
			} else {
				return("Chug Chug Chug");
			}

		}

	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Alcohol Pat = new Alcohol("Pat",21);

			Console.WriteLine (Pat.ToString());

		}
	}
}
