using System;


//Write a C function that takes two string as a parameter. 
//The function should populate the second string with the first string with all duplicates removed. 
//For example passing ABCCCDEFFA would populate the second string with ABCDEFA. 
//Dont worry if the second string has enough space. 

namespace stringdouble
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			string First = "AABCCCDEFF";

			//string Second = "";

			new populate (First);

		}
	}
}
