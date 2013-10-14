using System;

namespace Lecture4
{
	public class Dog
	{

		private string breed;
		public string Breed {
		get{ return breed;}
		set{ breed = value;}
	}
		private int age;
		public int Age{
			get{return age;}
			set{age = value;}
		}
		private string name;
		public string Name{
			get {return name;}
			set { name = value;}
		}
		public static int numLegs = 4;


		public Dog(string name, string breed, int age)
		{
			this.name = name;
			this.breed = breed;
			this.age = age;

		}

		public Dog()
			:this("","",-1)
		{
		}

		public void Bark()
		{
			Console.WriteLine (name + "Woof!");
			Console.WriteLine ("I Have " + Dog.numLegs + " legs");
		}
		
		

			



	}
}

