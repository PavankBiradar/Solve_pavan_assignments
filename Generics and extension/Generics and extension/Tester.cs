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
			string input = "pavankumar";

			Console.WriteLine("First letter case change:" + input.ChangeCase());
			input.Reverse();
			
		}
	}

}
