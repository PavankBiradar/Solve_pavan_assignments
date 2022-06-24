using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_extension
{
	public static class StringReverse
	{
		//Method to reverse the whole String
		public static void Reverse(this string input)
		{
			char[] letters = input.ToCharArray();
			for (int i = letters.Length-1; i>=0; i--) { 
			 Console.Write(letters[i]);
			}
			
		}


	}

}
