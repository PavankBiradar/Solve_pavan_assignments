using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_extension
{
	public class Tester
	{
		public static void Main(string[] args)
		{
			string str1 = "Pavankumar";

			Console.WriteLine("String reverse:" + str1.Reverse());
			Console.WriteLine("changes case,first letter to upper one: " + str1.ChangeFirstLetterToUpperCase());
			Console.WriteLine("changes case,first letter to lower one: " + str1.ChangeFirstLetterToLowerCase());
		}
	}

}
