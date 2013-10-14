using System;

namespace Lecture4
{
	public class Cat
	{
		public string name;

		public string Name {
			get {
				return name;
			}
			set{name = value;}
		}

		public int numLives;

		public int NumLives {
			get {
				return numLives;
			}
			set{numLives = value;}

		}

		public bool isAlive;

		public bool IsAlive {
			get {
				return isAlive;
			}
			set{isAlive = value;}
		}


		public Cat ()
		{

			numLives = 9;
			isAlive = true;

		}

		public void Die()
		{
			if (numLives > 0) {
				numLives--;
				Console.WriteLine ("Ouch! " + numLives + " Left");
			}

			if (numLives == 0) {
				isAlive = false;
			}
		}
		public void Meow()
		{
			if (isAlive) {
				Console.WriteLine ("Im Alive");
			} else {
				Console.WriteLine ("Im Dead");
			}
		
		}
		}
	}


