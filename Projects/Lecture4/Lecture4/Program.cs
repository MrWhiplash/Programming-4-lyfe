using System;

namespace Lecture4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Classes
			Dog misty = new Dog ("Misty", "King Charles", 4);
			Dog copper = new Dog ();
			copper.Name = "Copper";
			copper.Breed = "Labrador";
			copper.Age = 5;

			copper = misty;
			misty.Name = "Lovely Misty";
			Console.WriteLine (copper.Name);//Will Print Lovely Misty, the new name is CONSTANT




		



//			misty.Bark ();
//			copper.Bark ();
			
				

//			Cat KingLouis = new Cat ();
//			KingLouis.Meow ();
//			for(int i = 0; i < 9; i++)
//			{
//				KingLouis.Die ();
//			}
//
//			KingLouis.Meow ();





		}
	}
}
